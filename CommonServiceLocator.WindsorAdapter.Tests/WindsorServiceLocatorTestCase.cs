namespace CommonServiceLocator.WindsorAdapter.Tests
{
	using Castle.MicroKernel.Registration;
	using Castle.Windsor;
	using Components;
	using NUnit.Framework;

	[TestFixture]
	public class WindsorServiceLocatorTestCase : ServiceLocatorTestCase
	{
		protected override IServiceLocator CreateServiceLocator()
		{
			IWindsorContainer container = new WindsorContainer()
				.Register(
				Classes
					.FromAssemblyContaining<ILogger>()
					.BasedOn<ILogger>().WithService.FirstInterface()
				);
			return new WindsorServiceLocator(container);
		}

	}
}