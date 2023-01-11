using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Movie_App.Pages;
using Movie_App.MovieAppData;

namespace TestMovie_App
{
	public class TestMovies
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbTabsModule),
				typeof(IgniteUI.Blazor.Controls.IgbCardModule),
				typeof(IgniteUI.Blazor.Controls.IgbIconButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbDatePickerModule),
				typeof(IgniteUI.Blazor.Controls.IgbListModule),
				typeof(IgniteUI.Blazor.Controls.IgbAvatarModule));
			var mockHttpClient = new MockHttpClient().Create();
			ctx.Services.AddSingleton(new MovieAppDataService(mockHttpClient));
			var componentUnderTest = ctx.RenderComponent<Movies>();
			Assert.NotNull(componentUnderTest);
		}
	}
}