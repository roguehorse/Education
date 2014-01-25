/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package team_b_program;
import java.util.*;
import java.text.*;

/**
 *
 * @author Team_B
 */
class Team_B_Classes
{
    
}


class SalesPerson 
{
      // this class handles values and calculations for the modeled sales person.
    
    private boolean thHasAccelerationFactor=false; // class variable indicates whether incentive accelerator applies
    private boolean thEarnsCommission=false; // class variable indicates whether commission is earned, based on annual sales.
    private double thBaseSalary=75000.00; // class variable for Base Salary element   
    private double thAnnualSales=0.00;    // class variable for Sales element
    private double thCommissionRate=0.07; // class variable for Commission Rate element
    private double thTargetSales=120000.00;  // class variable for target sales goal
    private double thMinimumCompSales=0.8; // class variable for minimum percentage of target sales before Commission is earned
    private double thAccelerationFactor=1.5; // class variable for Commission Rate bonus factor for Exceeding sales goal
    private String thName=""; // Name of the Sales Person
    
    
    public void setName(String Name) {
        // set the salesperson's name
        thName=Name;
    } // end setName
    
    public String getName() {
        // return the saleseperson's name
        return thName;
    } // end getName
    
    public double getTotalCompensation() {
        // calculate total compensation based on private stored values
        return thBaseSalary+getCommission();
    } // end getTotalCompensation
    
    
    public double getCommission() {
        // calculate commission amount based on the stored rate and annual sales
        // if annual sales are less than thMinimumCompSales, 0
        // if annual sales are > target sales, use thCommissionRate*thAccelerationFactor
        // for annual sales between the two, use thCommissionRate
        
        double calculatedCommission=0.00; // default commission, target threshhold not met
        thHasAccelerationFactor=false;
        thEarnsCommission=false;
        
        if (thAnnualSales>=(getMinimumSalesForCommission())) {
            // sales must meet or exceed the target sales threashhold to receive commission
            thEarnsCommission=true;
            // check to see whether accelerator applies
            if (thAnnualSales<=thTargetSales) {
                // standard commission rate applies
                calculatedCommission=thAnnualSales*thCommissionRate;
            } else {
                // accelerator applies
                calculatedCommission=thAnnualSales*thCommissionRate*thAccelerationFactor;
                thHasAccelerationFactor=true;
            }
        }        
        
        return calculatedCommission;
    } // end getCommission
    
    public double getMinimumSalesForCommission() {
        // return minimum annual sales value a sales person must achieve in order to earn commission
        return thMinimumCompSales*thTargetSales;
    } // end getMinimumSalesForCommission
    
    public boolean getEarnsCommission() {
        // return whether or not commission is earned based on annaul sales
        return thEarnsCommission;
    } // end getEarnsCommission
    
    public double getTargetSalesValue() {
        // return stored value for private class variable for Target Sales
        return thTargetSales;
    } // end getTargetSalesValue
    
    public double getAccelerationFactor() {
        // return commision acceleration factor
        return thAccelerationFactor;
    } // end getAccelerationFactor
    
    public boolean getHasAccelerationFactor() {
        // return value of private class variable indicating whether acceleration factor applies
        return thHasAccelerationFactor;
    } // end getHasAccelerationFactor
    
    public double getBaseSalary () {
        // return stored base salary amount 
        return thBaseSalary;
    } // end getBaseSalary
    
    
    public void setBaseSalary(double baseSalary) {
        // allow modification of the private class variable for base salary
        thBaseSalary=baseSalary;
    } // end setBaseSalary
    
    
    public double getAnnualSales () {
        // return the value for the private class variable for annual sales total
        return thAnnualSales;
    } // end getAnnualSales
    
    
    public void setSales(double annualSales) {
        // allow modification of the private class variable for annual sales
        thAnnualSales=annualSales;
        getTotalCompensation();
    } // end setSales
    
    
    public double getCommissionRate() {
        // return the value for the private class variable for commission rate
        return thCommissionRate;
    } // end getCommissionRate
    
    
    public void setCommissionRate(double commissionRate) {
        // allow modification of the private class variable for commission rate
        thCommissionRate=commissionRate;
    } // end setCommissionRate 
    
    double goalAccel()//Sales goal acceleration value
    {
        double goalaccel = 0.015;//sales goal acceleration !!Change value above only!!
        return goalaccel;
    }
    
    double startIncentive()//Sales incentive initiation value
    {
        double startincent = .80;//incentive start !!Change value above only!!
        return startincent;
    }
}

/**********************COLLECT NAMES OF SALES PERSONS**************************/
class Names
{
 ArrayList<String> names = new ArrayList<>();//Collect names of two salespeople in an ArrayList
 Scanner input = new Scanner ( System.in );//Invoke scanner to collect input

   public void NameInput()
    {
      for (int x=1; x<3; x++)//Loop until both names are entered into ArrayList
      {
        String sp1 = "Please enter saleperson " + x + " first name   >>   ";
        System.out.printf("%52s",sp1);
        names.add(input.next());
      }
      System.out.println();
    }
}

/**************COLLECT ANNUAL SALES AMOUNTS FROM SALES PERSONS*****************/
class Annual
{
 ArrayList<String> names = new ArrayList<>();    
 ArrayList<Double> asales = new ArrayList<>();
 Scanner input = new Scanner ( System.in );

   public void AnnualInput()
    {
       double z;//Assign variable for validation loop prior to assigning to ArrayList
       for (int x=1; x<3; x++)//Loop twice for two sales people
       {
        String sp2 = "Please enter saleperson " + x + " sales   >>   $";
        System.out.printf("%53s",sp2);
        z = input.nextDouble();//Assign input to variable
        if (z <= 0)//Determine if variable holds a valid input
        {
            String validate1 = "!!  Please enter a value greater than 0  !!";//Ask for valid input
            System.out.printf("%73s",validate1);
            System.out.println();
            x = x-1;//Remove one from loop counter until input is valid
        }
        
        else
        {
           asales.add(z);//Add input from variable to ArrayList once validated
        }
        
       }
       System.out.println();
    }   
}