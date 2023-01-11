using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Movie_App.Pages;

namespace TestMovie_App
{
	public class TestMovieComplex
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor();
			var componentUnderTest = ctx.RenderComponent<MovieComplex>();
			Assert.NotNull(componentUnderTest);
		}
	}
}