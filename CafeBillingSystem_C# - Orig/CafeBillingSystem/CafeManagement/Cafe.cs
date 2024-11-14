using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement
{
    class Cafe
    {

        //Default Constructor
        public Cafe()
        {
            newlatteeCofM = 0.0;
            newmochaCofM = 0.0;
            newespressoCofM = 0.0;
            newvaleCoffeeM = 0.0;
            newcappCofM = 0.0;
            newcaraMachM = 0.0;
            newbrewCofM = 0.0;
            newfrenchVanM = 0.0;

            newlatteeCofL = 0.0;
            newmochaCofL = 0.0;
            newespressoCofL = 0.0;
            newvaleCoffeeL = 0.0;
            newcappCofL = 0.0;
            newcaraMachL = 0.0;
            newbrewCofL = 0.0;
            newfrenchVanL = 0.0;

            newcofCake = 0.0;
            newredVelvet = 0.0;
            newbForest = 0.0;
            newbbCheese = 0.0;
            newuCust = 0.0;
            newmoistChoco = 0.0;
            newcarCake = 0.0;
            newmoCake = 0.0;
        }

        //Set Method
        public Cafe(double latteeCofM,double mochaCofM,double espressoCofM,double valeCoffeeM, double cappCofM,double caraMachM,double brewCofM,double frenchVanM,
                    double latteeCofL, double mochaCofL, double espressoCofL, double valeCoffeeL, double cappCofL, double caraMachL, double brewCofL, double frenchVanL,
                  double cofCake,double redVelvet,double bForest,double bbCheese, double uCust, double moistChoco,double carCake,double moCake)
        {
            newlatteeCofM = latteeCofM;
            newmochaCofM = mochaCofM;
            newespressoCofM = espressoCofM;
            newvaleCoffeeM = valeCoffeeM;
            newcappCofM = cappCofM;
            newcaraMachM = caraMachM;
            newbrewCofM = brewCofM;
            newfrenchVanM = frenchVanM;

            newlatteeCofL = latteeCofL;
            newmochaCofL = mochaCofL;
            newespressoCofL = espressoCofL;
            newvaleCoffeeL = valeCoffeeL;
            newcappCofL = cappCofL;
            newcaraMachL = caraMachL;
            newbrewCofL = brewCofL;
            newfrenchVanL = frenchVanL;

            newcofCake = cofCake;
            newredVelvet = redVelvet;
            newbForest = bForest;
            newbbCheese = bbCheese;
            newuCust = uCust;
            newmoistChoco = moistChoco;
            newcarCake = carCake;
            newmoCake = moCake;    

        }

        //get Method
        public double getLatteCofM() { return newlatteeCofM; }
        public double getMochaCofM() { return newmochaCofM; }
        public double getEspresCofM() { return newespressoCofM; }
        public double getValeCofM() { return newvaleCoffeeM; }
        public double getCappCofM() { return newcappCofM; }
        public double getCaraMachM() { return newcaraMachM; }
        public double getBrewCofM() { return newbrewCofM; }
        public double getFrenchVanM() { return newfrenchVanM; }
        public double getLatteCofL() { return newlatteeCofL; }
        public double getMochaCofL() { return newmochaCofL; }
        public double getEspresCofL() { return newespressoCofL; }
        public double getValeCofL() { return newvaleCoffeeL; }
        public double getCappCofL() { return newcappCofL; }
        public double getCaraMacLh() { return newcaraMachL; }
        public double getBrewCofL() { return newbrewCofL; }
        public double getFrenchVanL() { return newfrenchVanL; }
        public double getCofCake() { return newcofCake; }
        public double getRedVelvet() { return newredVelvet; }
        public double getBForest() { return newbForest; }
        public double getBbCheese() { return newbbCheese; }
        public double getUCust() { return newuCust; }
        public double getMoistChoco() { return newmoistChoco; }
        public double getCarCake() { return newcarCake; }
        public double getMoCake() { return newmoCake; }


        //Coffee
        private double newlatteeCofM;
        private double newmochaCofM;
        private double newespressoCofM;
        private double newvaleCoffeeM;
        private double newcappCofM;
        private double newcaraMachM;
        private double newbrewCofM;
        private double newfrenchVanM;

        private double newlatteeCofL;
        private double newmochaCofL;
        private double newespressoCofL;
        private double newvaleCoffeeL;
        private double newcappCofL;
        private double newcaraMachL;
        private double newbrewCofL;
        private double newfrenchVanL;

        //Cakes
        private double newcofCake;
        private double newredVelvet;
        private double newbForest;
        private double newbbCheese;
        private double newuCust;
        private double newmoistChoco;
        private double newcarCake;
        private double newmoCake;
    }
}
