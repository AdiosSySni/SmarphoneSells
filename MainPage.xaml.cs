namespace SmarphoneSells;

public partial class MainPage : ContentPage
{
    public int cost;

    public int phoneCost;
    public int stuffCost;

	public MainPage()
	{
		InitializeComponent();
    }

    private void RadioButton_PhoneSelected(object sender, CheckedChangedEventArgs e)
    {
        RadioButton selectedRadioButton = ((RadioButton)sender);
        CostValue(selectedRadioButton.Value.ToString()); 
    }

    public int CostValue(string radioButtonValue)
    {
        Cost.Text = "Общая стоимость: " +  radioButtonValue;
        return phoneCost = Convert.ToInt32(radioButtonValue);
    }

    private void RadioButton_StuffSelected(object sender, CheckedChangedEventArgs e)
    {
        RadioButton selectedRadioButton = ((RadioButton)sender);
        CostValueEnding(Convert.ToInt32(selectedRadioButton.Value), phoneCost);
    }

    public int CostValueEnding(int radioButtonValue, int phoneCost)
    {
        stuffCost = radioButtonValue;
        Cost.Text = "Общая стоимость: " + (stuffCost + phoneCost);

        return cost = stuffCost + phoneCost;
        //stuffCost += radioButtonValue;
        //Cost.Text = "Общая стоимость: " +  cost.ToString(); 
    }


}

