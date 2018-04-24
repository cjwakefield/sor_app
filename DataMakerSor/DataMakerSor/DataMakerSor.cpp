// DataMakerSor.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"


//
//  main.cpp
//  JMie
//
//  Created by Justin Maughan on 8/13/15.
//  Copyright (c) 2015 Justin Maughan. All rights reserved.
//

#include <iostream>
#include "nr3.h"
#include <sstream>


/*

I am using numerical recipes c++ header file i find i makes working with the complex stuff easier and includes many of the header files i normally use let me know if you run into issues with this and i will change everything to work without it
*/
double pi = 4 * atan(1); // easy way to get pi
using namespace std;


/*
the following functions are all set and tested you should not change them
*/
//------------------------------------------------------------------//
void calc_Anx(Complex *Anx, int nmax, double x);
void calc_Anmx(Complex *Anmx, int nmax, Complex mx);
void calc_Bnx(Complex *Bnx, int nmax, double x);
void calc_Bnmx(Complex *Bnmx, int nmax, Complex mx);
void calc_psinx(Complex *Anx, Complex *psinx, int nmax, double x);
void calc_psinmx(Complex *Anmx, Complex *psinmx, int nmax, Complex mx);
void calc_xix(Complex *Bnx, Complex *xix, int nmax, double x);
void calc_xinmx(Complex *Bnmx, Complex *xinmx, int nmax, Complex mx);
Complex En(int n);
Complex Enr(int n);
//------------------------------------------------------------------//
void Calc_scat(double x, Complex m, double nang, vector<double>& s11, vector<double>& s12, vector<double>& theta, double& Csca, double& Cext, double k);

double inverfc(double p);

inline double inverf(double p);

double invcdf(double p, double ro, double sig);

double Dofr(double mu, double sig, double r)
{
	double temp = r / mu;
	double temp1 = (-2)*log(sig)*log(sig);

	temp = log(temp)*log(temp);
	temp = exp(temp / temp1);
	temp1 = sqrt(2 * 4 * atan(1))*mu*log(sig)*exp(.5*log(sig)*log(sig));

	temp = temp / temp1;

	return temp;

}



int calc_Data(double lambda, double sigma, double realm, double kappa, double mu)
{

	double k = (2 * pi) / lambda; // wave vector of incedent field
	int nang = 10000;



	double Csca = 0;//never done anything with these for a size dist don't think you will need to but let me know if you do 
	double Cext = 0;
	double Cabs = 0;

	Complex m = Complex(realm, kappa);

	double x = k*mu;  // size parameter of the particles

	double mustart = mu / (sigma*sigma*sigma*sigma);  //these set how far out in the distribution to intergrate over
	double muend = mu*(sigma*sigma*sigma*sigma);
	//kappa = (0.0001/x);


	vector<double> rs; //hold the radii to be intergrated
						//----------------------------------------------------------//



	double sqrtf = ((realm*realm - kappa*kappa - 1)*(realm*realm - kappa*kappa - 1) + 4 * realm*realm*kappa*kappa);
	sqrtf = sqrtf / ((realm*realm - kappa*kappa + 2)*(realm*realm - kappa*kappa + 2) + 4 * realm*realm*kappa*kappa);
	sqrtf = sqrt(sqrtf);

	double rhoprime = 2 * k*mu*sqrtf;
	double ray = pow(mu, 6.0)*pow(k, 4.0)*sqrtf*sqrtf;


	for (double r = mustart; r <= muend; r = r*1.01) {
		rs.push_back(r); //filling vector with radii to be intergrated over
	}

	vector<double> theta;
	vector<double> s11;
	vector<double> s12; //these are for each indivdual calculation
	vector<double> s11t;// the t is for the total intergrated dist
	vector<double> s12t;

	for (int k = 0; k <= nang; k++) {
		s11t.push_back(0);
		s12t.push_back(0);
	}

	for (int i = 2; i < rs.size() - 2; i++) {
		s11.resize(0);
		s12.resize(0);
		theta.resize(0);

		double r = rs[i];
		cout << r << endl;
		x = k*r;

		double dr = rs[i] - rs[i - 1];

		Calc_scat(x, m, nang, s11, s12, theta, Csca, Cext, k);

		for (int j = 0; j < s11.size(); j++) {
			s11t[j] = s11t[j] + ((s11[j]))*Dofr(mu, sigma, r)*dr;
			s12t[j] = s12t[j] + ((s12[j]))*Dofr(mu, sigma, r)*dr;


		}

	}

	Cabs = Cext - Csca; //Cext is equal to the sum of scatting and absorption cross sections
	string outstring = "out_" + to_string(rhoprime) + "_" + to_string(realm) + ".txt";
	ofstream out;
	out.open(outstring);

	double qr = 0;
	for (int i = 0; i < s11.size(); i++) {
		qr = 2 * k*mu*sin(theta[i] / 2.0);
		out << theta[i] * (180 / pi) << "    " << qr << "      " << (s11t[i] - s12t[i]) / (k*k);  //outputs the perpidicular polarization differential cross seciton
		out << "      " << (s11t[i] + s12t[i]) / (k*k); //outputs the parallel polarization differential cross seciton
		out << "      " << (s11t[i]) / (k*k) ;//outputs the un-polarized differential cross seciton
		out << "      " << (s11t[i] - s12t[i]) / (k*k*ray);  //outputs the perpidicular polarization differential cross seciton
		out << "      " << (s11t[i] + s12t[i]) / (k*k*ray); //outputs the parallel polarization differential cross seciton
		out << "      " << (s11t[i]) / (k*k*ray) << endl;//outputs the un-polarized differential cross seciton

														//if you want to rayleigh normalize you divide by (k*k*ray) instead of just (k*k)
														//if you want to plot vs theta you have to covert to degrees theta[i]*(180.0/pi)

	}
	out.close();

	return 0;
}

int main( int argc, const char * argv[])
{
	if (argc > 1)
	{
		if (argc == 6)
		{
			double numbers[5];
			for (int i = 1; i < argc ; i += 1)
			{
				numbers[i-1] = strtod(argv[i], NULL);
				cout << numbers[i - 1] ;

			}
			//double lambda, double sigma, double realm, double kappa, double mu
			calc_Data(numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]); 
		}
		else
		{

		}
	}
	else
	{
		double lambda;   // wave length on incedent field
		cout << "lambda: \n ";
		cin >> lambda;
		cout << lambda;
		cout << "\n";

		double k = (2 * pi) / lambda; // wave vector of incedent field
		int nang = 10000;

		double sigma; // standard deviation of the log normal dist
		cout << "sigma: \n ";
		cin >> sigma;
		cout << sigma;
		cout << "\n";

		double Csca = 0;//never done anything with these for a size dist don't think you will need to but let me know if you do 
		double Cext = 0;
		double Cabs = 0;

		double realm;  // real part of the index of refraction
		cout << "realm: \n ";
		cin >> realm;
		cout << realm;
		cout << "\n";

		double kappa; // imaginary part of the index of refraction
		cout << "kappa: \n ";
		cin >> kappa;
		cout << kappa;
		cout << "\n";


		Complex m = Complex(realm, kappa);

		double mu;  //mean radius of the log normal dist
		cout << "mu: \n ";
		cin >> mu;
		cout << mu;
		cout << "\n";

		double x = k*mu;  // size parameter of the particles

		double mustart = mu / (sigma*sigma*sigma*sigma);  //these set how far out in the distribution to intergrate over
		double muend = mu*(sigma*sigma*sigma*sigma);
		//kappa = (0.0001/x);


		vector<double> rs; //hold the radii to be intergrated
							//----------------------------------------------------------//



		double sqrtf = ((realm*realm - kappa*kappa - 1)*(realm*realm - kappa*kappa - 1) + 4 * realm*realm*kappa*kappa);
		sqrtf = sqrtf / ((realm*realm - kappa*kappa + 2)*(realm*realm - kappa*kappa + 2) + 4 * realm*realm*kappa*kappa);
		sqrtf = sqrt(sqrtf);

		double rhoprime = 2 * k*mu*sqrtf;
		double ray = pow(mu, 6.0)*pow(k, 4.0)*sqrtf*sqrtf;


		for (double r = mustart; r <= muend; r = r*1.01) {
			rs.push_back(r); //filling vector with radii to be intergrated over
		}

		vector<double> theta;
		vector<double> s11;
		vector<double> s12; //these are for each indivdual calculation
		vector<double> s11t;// the t is for the total intergrated dist
		vector<double> s12t;

		for (int k = 0; k <= nang; k++) {
			s11t.push_back(0);
			s12t.push_back(0);
		}

		for (int i = 2; i < rs.size() - 2; i++) {
			s11.resize(0);
			s12.resize(0);
			theta.resize(0);

			double r = rs[i];
			cout << r << endl;
			x = k*r;

			double dr = rs[i] - rs[i - 1];

			Calc_scat(x, m, nang, s11, s12, theta, Csca, Cext, k);

			for (int j = 0; j < s11.size(); j++) {
				s11t[j] = s11t[j] + ((s11[j]))*Dofr(mu, sigma, r)*dr;
				s12t[j] = s12t[j] + ((s12[j]))*Dofr(mu, sigma, r)*dr;


			}

		}

		Cabs = Cext - Csca; //Cext is equal to the sum of scatting and absorption cross sections
		string outstring = "out_" + to_string(rhoprime) + "_" + to_string(realm) + ".txt";
		ofstream out;
		out.open(outstring);

		double qr = 0;
		for (int i = 0; i < s11.size(); i++) {
			qr = 2 * k*mu*sin(theta[i] / 2.0);
			out << theta[i] * (180 / pi) << "    " << qr << "      " << (s11t[i] - s12t[i]) / (k*k);  //outputs the perpidicular polarization differential cross seciton
			out << "      " << (s11t[i] + s12t[i]) / (k*k); //outputs the parallel polarization differential cross seciton
			out << "      " << (s11t[i]) / (k*k) << endl;//outputs the un-polarized differential cross seciton

																//if you want to rayleigh normalize you divide by (k*k*ray) instead of just (k*k)
																//if you want to plot vs theta you have to covert to degrees theta[i]*(180.0/pi)

		}
		out.close();
	}
	return 0;

}
double inverfc(double p) {
	double x, err, t, pp;
	if (p >= 2.0) return -100.;
	if (p <= 0.0) return 100.;
	pp = (p < 1.0) ? p : 2. - p;
	t = sqrt(-2.*log(pp / 2.));
	x = -0.70711*((2.30753 + t*0.27061) / (1. + t*(0.99229 + t*0.04481)) - t);
	for (int j = 0; j < 2; j++) {
		err = erfc(x) - pp;
		x += err / (1.12837916709551257*exp(-SQR(x)) - x*err);
	}
	return (p < 1.0 ? x : -x);
}

inline double inverf(double p)
{
	return inverfc(1. - p);
}
void calc_Anx(Complex *Anx, int nmax, double x)
{
	for (int i = nmax - 1; i >= 1; i--) {

		Anx[i] = (i + 1.0) / x - 1.0 / (((i + 1.0) / x) + Anx[i + 1]);
	}
}
void calc_Anmx(Complex *Anmx, int nmax, Complex mx)
{


	for (int i = nmax - 1; i >= 1; i--) {

		Anmx[i] = (i + 1.0) / mx - 1.0 / (((i + 1.0) / mx) + Anmx[i + 1]);
	}
}
void calc_Bnx(Complex *Bnx, int nmax, double x)
{
	Bnx[0] = Complex(0.0, 1.0);
	for (int i = 1; i < nmax; i++) {

		Bnx[i] = -(i / x) + 1.0 / ((i / x) - Bnx[i - 1]);
	}
}
void calc_Bnmx(Complex *Bnmx, int nmax, Complex mx)
{
	Bnmx[0] = Complex(0.0, 1.0);
	for (int i = 1; i < nmax; i++) {

		Bnmx[i] = -((i*1.0) / mx) + 1.0 / (((i*1.0) / mx) - Bnmx[i - 1]);
	}

}

void calc_psinx(Complex *Anx, Complex *psinx, int nmax, double x)
{
	psinx[0] = Complex(sin(x), 0);
	for (int i = 1; i < nmax; i++) {

		psinx[i] = psinx[i - 1] / (Anx[i] + (i / x));

	}

}
void calc_psinmx(Complex *Anmx, Complex *psinmx, int nmax, Complex mx)
{
	psinmx[0] = Complex(sin(real(mx))*cosh(imag(mx)), cos(real(mx))*sinh(imag(mx)));
	for (int i = 1; i < nmax; i++) {

		psinmx[i] = psinmx[i - 1] / (Anmx[i] + ((i*1.0) / mx));
	}

}
void calc_xix(Complex *Bnx, Complex *xix, int nmax, double x)
{
	xix[0] = Complex(sin(x), -cos(x));
	for (int i = 1; i < nmax; i++) {

		xix[i] = xix[i - 1] / (Bnx[i] + (i*1.0 / x));

	}
}
void calc_xinmx(Complex *Bnmx, Complex *xinmx, int nmax, Complex mx)
{
	xinmx[0] = Complex(sin(real(mx))*cosh(imag(mx)) - sin(real(mx))*sinh(imag(mx)), cos(real(mx))*sinh(imag(mx)) - cos(real(mx))*cosh(imag(mx)));
	for (int i = 1; i < nmax; i++) {

		xinmx[i] = xinmx[i - 1] / (Bnmx[i] + ((i*1.0) / mx));
	}
}
Complex En(int n)
{
	Complex temp = Complex(0.0, 1.0);
	temp = pow(temp, n);

	double temp1 = ((2 * 1.0*n + 1) / (n*1.0*(n*1.0 + 1)));
	return (temp*temp1);

}
Complex Enr(int n)
{
	Complex temp = Complex(0.0, 1.0);
	temp = pow(temp, n);

	double temp1 = ((2 * 1.0*n + 1));
	return (temp*temp1);

}
void Calc_scat(double x, Complex m, double nang, vector<double>& s11, vector<double>& s12, vector<double>& theta, double& Csca, double& Cext, double k)
{

	s11.resize(0);
	s12.resize(0);
	/*
	these control the recursion formulas for calculation of special functions and should not be changed
	*/
	//-----------------------------------------------------------------------------------//
	Complex mx = m*x;
	const int xstop = x + 4.E0*pow(x, 0.3333) + 20.0;
	double ymod = abs(mx);
	const int nmax = MAX(xstop, ymod) + 15;
	//-----------------------------------------------------------------------------------//


	Complex *psinx = new Complex[nmax];
	Complex *psinmx = new Complex[nmax];

	Complex *xix = new Complex[nmax];
	Complex *xinmx = new Complex[nmax];

	Complex *Anx = new Complex[nmax + 1];
	Complex *Anmx = new Complex[nmax + 1];

	Complex *psinmrk = new Complex[nmax];
	Complex *Anmrk = new Complex[nmax];

	Complex *Bnx = new Complex[nmax];
	Complex *Bnmx = new Complex[nmax];

	Complex *cn = new Complex[nmax];
	Complex *dn = new Complex[nmax];

	Complex *an = new Complex[nmax];
	Complex *bn = new Complex[nmax];


	int count = 0;
	for (int i = 0; i < nmax; i++) {
		Anx[i] = Complex(0, 0);
		Anmx[i] = Complex(0, 0);
		Bnx[i] = Complex(0, 0);
		Bnmx[i] = Complex(0, 0);
		xix[i] = Complex(0, 0);
		xinmx[i] = Complex(0, 0);
		psinx[i] = Complex(0, 0);
		psinmx[i] = Complex(0, 0);
		psinmrk[i] = Complex(0, 0);
		Anmrk[i] = Complex(0, 0);
		dn[i] = Complex(0, 0);
		cn[i] = Complex(0, 0);
		an[i] = Complex(0, 0);
		bn[i] = Complex(0, 0);
	}


	Anx[nmax] = Complex(0, 0);
	Anmx[nmax] = Complex(0, 0);
	calc_Anx(Anx, nmax, x);
	calc_Anmx(Anmx, nmax, mx);
	calc_Bnx(Bnx, nmax, x);
	calc_Bnmx(Bnmx, nmax, mx);
	calc_psinmx(Anmx, psinmx, nmax, mx);
	calc_psinx(Anx, psinx, nmax, x);
	calc_xix(Bnx, xix, nmax, x);
	calc_xinmx(Bnmx, xinmx, nmax, mx);

	Complex temp1 = Complex(0, 0);
	Complex temp2 = Complex(0, 0);
	Complex temp3 = Complex(0, 0);
	for (int i = 1; i <= xstop; i++) {

		temp1 = Bnx[i] - Anx[i];
		temp2 = (Bnx[i] / m) - Anmx[i];
		temp3 = psinx[i] / psinmx[i];
		cn[i] = temp3*(temp1 / temp2);

		temp2 = (Bnx[i]) - (Anmx[i] / m);
		dn[i] = temp3*(temp1 / temp2);

		temp1 = m*Anx[i] - Anmx[i];
		temp2 = m*Bnx[i] - Anmx[i];
		temp3 = psinx[i] / xix[i];
		an[i] = temp3*(temp1 / temp2);

		temp1 = Anx[i] - Anmx[i] * m;
		temp2 = Bnx[i] - Anmx[i] * m;
		temp3 = psinx[i] / xix[i];
		bn[i] = temp3*(temp1 / temp2);


	}

	double taun = 0;
	double pii_minus_2 = 0;
	double pii_minus_1 = 1;
	double piin = 1;

	double tempa = 0;
	double tempb = 0;



	vector<Complex> s1;
	vector<Complex> s2;
	vector<double> th;

	double costheta = 0;
	double dth = pi / nang;
	double thet = 0;
	for (int k = 0; k <= nang; k++) {
		thet = k*dth;
		theta.push_back(thet);
		// cout << thet << endl;
		costheta = cos(thet);
		taun = costheta;
		pii_minus_2 = 0;
		pii_minus_1 = 1;
		piin = 1;
		Complex S1temp = Complex(0, 0);
		Complex S2temp = Complex(0, 0);
		double coef = 0;
		for (int i = 1; i <= xstop; i++)
		{
			if (2 <= i)
			{
				tempa = (((2.0*i) - 1.0) / (i - 1.0));
				tempb = ((i*1.0) / ((i*1.0) - 1.0));
				piin = tempa*costheta*pii_minus_1 - tempb*pii_minus_2;
				taun = i*costheta*piin - (i + 1.0)*pii_minus_1;
				pii_minus_2 = pii_minus_1;
				pii_minus_1 = piin;
			}
			coef = (2.0*i + 1.0) / (i*(i + 1.0));
			S1temp = S1temp + coef*(an[i] * piin + bn[i] * taun);
			S2temp = S2temp + coef*(an[i] * taun + bn[i] * piin);



		}

		s1.push_back(S1temp);
		s2.push_back(S2temp);
		th.push_back(thet);




	}

	Csca = 0;
	Cext = 0;
	complex<double> Cexttemp = complex<double>(0, 0);
	for (int i = 1; i <= xstop; i++)
	{
		Csca = Csca + (2 * i + 1)*(abs(an[i])*abs(an[i]) + abs(bn[i])*abs(bn[i]));
		Cexttemp = Cexttemp + (2.0*i + 1.0)*(an[i] + bn[i]);
	}
	Csca = Csca*((2 * pi) / (k*k));
	Cext = real(Cexttemp);
	Cext = Cext*((2 * pi) / (k*k));
	for (int i = 0; i < s1.size(); i++) {
		s11.push_back(0.5*(abs(s1[i])*abs(s1[i]) + abs(s2[i])*abs(s2[i])));
		s12.push_back(0.5*(abs(s2[i])*abs(s2[i]) - abs(s1[i])*abs(s1[i])));
	}
}


