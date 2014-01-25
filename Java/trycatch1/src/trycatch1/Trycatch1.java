/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package trycatch1;

public class Trycatch1 
{

    public static void main(String[] args) 
    {
        try
        {
          for(int i=5;i>=0;i--)
              System.out.println(10/i);
        }
        catch(Exception ex)
                {
                    System.out.println("Exception Message: " + ex.getMessage());
                }
        System.out.println("After for loop...");
    }
        
}
