using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Movie_App.Pages;
using Movie_App.MovieAppData;

namespace TestMovie_App
{
	public class TestMyPurchasesBackup
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbListModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule));
			var mockHttpClient = new MockHttpClient().Create();
			ctx.Services.AddSingleton(new MovieAppDataService(mockHttpClient));
			var componentUnderTest = ctx.RenderComponent<MyPurchasesBackup>();
			Assert.NotNull(componentUnderTest);
		}
	}
}