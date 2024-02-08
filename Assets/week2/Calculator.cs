using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Calculator : MonoBehaviour
{
    //TODO: Create a TextMeshProUGUI variable here and assign it in the inspector

    public TextMeshProUGUI myTextMeshPro;

    //TODO: Create a temporary float variable here called prevInput so we can store the previous input value
    //      when performaing calculations
  
    private float prevInput;
    
    //TODO: Create a bool variable called clearPrevInput here so we can flip it to true/false if we should clear the prior input
    //      when typing in values. Example, if we type in the value 402 and then press the + button, the next value I enter
    //      should replace the 402 I previously entered
    
    private bool clearPrevInput = true;
    

  
    //void OnPlusButtonPressed()
    //{
       // clearPrevInput = true;
   // }//

    //TODO: Leave this alone
    private EquationType equationType;

    private void Start()
    {
        Clear();
    }

    public void AddInput(string input)
    {
        //TODO: Check the clearPrevInput variable you created
        //      and if true then set the current value of the text label to be string.Empty
        //      and set the clearPrevInput value to false
        if (clearPrevInput)
        {

            myTextMeshPro.text = string.Empty;
            clearPrevInput =false;

        }




        //TODO: Add the input passed into the AddInput function to the current value of the label
        //      Hint. You can perform the + operations on string data to combine them
        // myTextMeshPro.text += input;
        //prevInput = float.Parse(myTextMeshPro.text);
        text.text += input;

    }

    public void SetEquationAsAdd()
    {
        //TODO: Store the current
        // input value on the text label into the float variable you created.
        // these lines of code is when a button is click then set public void Calculate to as public void public void SetEquationAsAdd()
        if (float.TryParse(myTextMeshPro.text, out float parsedInput))
        {
            prevInput = parsedInput;
        }
      
        //      Hint. You will need to google float.Parse() and pass in the string value of the label.
        //TODO: Set the bool you made to true so that the next number that gets typed in clears the calculator display.
        prevInput = float.Parse(text.text);
        clearPrevInput = true;  //clear any other options
        equationType = EquationType.ADD; // set it to add
    }
    public TextMeshProUGUI text;


    //TODO: Create a SetEquationAsSubtract function similar to SetEquationAsAdd.
    //      Make sure you set equationType to EquationType.SUBTRACT
    public void SetEquationAsSubtract()
    {
        // these lines of code is when a button is click then set public void Calculate to as public void SetEquationAsSubtract()
        if (float.TryParse(myTextMeshPro.text, out float parsedInput))
        {
            prevInput = parsedInput;
        }

        clearPrevInput = true;  //clear any other options

        equationType = EquationType.SUBTRACT; // set it as subtract
    }


    //TODO: Create a SetEquationAsMultiply function similar to SetEquationAsAdd.
    //      Make sure you set equationType to EquationType.Multiply
    public void SetEquationAsMultiply()
    {
        // these lines of code is when a button is click then set public void Calculate to as public void SetEquationAsMultipl
        if (float.TryParse(myTextMeshPro.text, out float parsedInput))
        {
            prevInput = parsedInput;
        }

  
        clearPrevInput = true; //clear any other options

        equationType = EquationType.MULTIPLY; // set it as multiply 
    }

    //TODO: Create a SetEquationAsDivide function similar to SetEquationAsAdd.
    //      Make sure you set equationType to EquationType.DIVIDE
    public void SetEquationAsDivide()
    {
        // these lines of code is when a button is click then set public void Calculate to as   public void SetEquationAsDivide()  
        if (float.TryParse(myTextMeshPro.text, out float parsedInput))
        {
            prevInput = parsedInput;
        }
        clearPrevInput = true; //clear any other options

        equationType = EquationType.DIVIDE; // set it as divide
    }
    public void Add()
    {
        // this codd allows you to add 2 number together

        float currentInput = float.Parse(myTextMeshPro.text);
        float result = prevInput + currentInput;
        myTextMeshPro.text = result.ToString();
    }

    //TODO: Implement Subtract function

    public void Subtract() // create the subtract function
    {
     // these lines of code is allows you to subtract and  
        float currentInput = float.Parse(myTextMeshPro.text);
        float result = prevInput - currentInput;
        myTextMeshPro.text = result.ToString();
    }
    //TODO: Implement Multiply function
    public void Multiply()
    {
        //this code allows you to mutiply 2 number
        float currentInput = float.Parse(myTextMeshPro.text);
        float result = prevInput * currentInput;
        myTextMeshPro.text = result.ToString();
    }

    //TODO: Implement Divide function
    public void Divide()
    {
     //this code allows you to divide 2 numbers unless it 0
        float currentInput = float.Parse(myTextMeshPro.text);

        if (currentInput != 0f) 
        {
            float result = prevInput / currentInput;
            myTextMeshPro.text = result.ToString();
        }
        else
        {
            
            Debug.LogWarning("Division by zero is not allowed.");
        }
    }

    public void Clear()
    {
        //TODO: Reset the state of your calculator... reset the display value to a 0, reset the bool variable
        //      that represents if the display should be cleared to true, reset the temporary float variable as well to 0
        myTextMeshPro.text = "0"; // when it cleared make it 0
        clearPrevInput = true;
        prevInput = 0f;
        // this code sets text back to 0 if the button is clicked

        //TODO: Leave this alone
        equationType = EquationType.None;        
    }

    public void Calculate()
    {
        //TODO: Check if equationTypep is Add/Subtract/Multiply/Divide and call the correct function
        if (equationType == EquationType.ADD) Add();
        else if (equationType == EquationType.SUBTRACT) Subtract();
        else if (equationType == EquationType.MULTIPLY) Multiply();
        else if (equationType == EquationType.DIVIDE) Divide();
        // this code check what button you click out of add, subtract, multipply and divide and then exicute that code
        // so if you cick equals it will check the if it curently adding or subtracting and complete that cation.

    }

    //TODO: Leave this alone
    public enum EquationType
    {
        None = 0,
        ADD = 1,
        SUBTRACT = 2,
        MULTIPLY = 3,
        DIVIDE = 4
    }
}
