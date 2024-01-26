Date: 1/20/2024
Class: CSE 210
Professor: Vaughn Poulson
Student: Jeeyoung Madsen

Encapsulation - Articulate

1. Meaning of Encapsulation that The idea is to encapsulate the internal workings of an object,
    providing a protective barrier that restricts direct access to the object's internal state.
    * the act of enclosing somthing
    * hiding the detail of behaviors
        (thinking carefully about behaviors)

2. A class be responsible for the details of a particular task.
    Preventing other of the program from accessing those details.

3. * If something is broken, any code. that has access might be to blame.
    * if something needs to chang, any code that has access might need to change.

4. 
public class Fraction
{
    private int _numerator;
    private int _denominator;


    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    
    public Fraction(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }
    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;

    }
}
The internal details of programs are encapsulated within the class, 
and external code interacts with the account through the defined methods.



