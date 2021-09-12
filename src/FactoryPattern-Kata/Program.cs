using System;


namespace FactoryPattern_Kata
{
	class Program
	{
		static void Main(string[] args)
		{
			var sampleTest = new FactoryTest();
			sampleTest.Check_activation_returns_false_with_hardware_check_and_expired();
			sampleTest.Check_activation_returns_false_with_hardware_check_and_maximum_activations_reached();
			sampleTest.Check_activation_returns_false_with_no_hardware_check_and_expired();
			sampleTest.Check_activation_returns_true_with_hardware_check();
			sampleTest.Check_activation_returns_true_with_hardware_check_and_maximum_activations_reached_but_already_active();
			sampleTest.Check_activation_returns_true_with_no_hardware_check_and_not_expired();
			Console.WriteLine();
		}
	}
}