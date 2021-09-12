using FactoryPattern_Kata.Core;

namespace FactoryPattern_Kata.Interfaces
{
	public interface IChecker
	{
		bool Check(ActivationData activation_data, License license_data);
	}
}