namespace FactoryPattern_Kata
{
	public interface IChecker
	{
		bool Check(ActivationData activation_data, License license_data);
	}
}