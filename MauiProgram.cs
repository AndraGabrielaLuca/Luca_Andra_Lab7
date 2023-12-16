namespace Luca_Andra_Lab7;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.ConfigureEssentials(essentials =>
			{
				essentials.UseMapServiceToken("rW4JzYeNFtENlKdGBnC6~gOUqpq6JhfNICeYLhPTrCQ~AtjCcXwNgkS91C6ZDQg3ad2YoUWqpUEBDtAeahARD41TNk7CnVzYZN7eQxUdJIyn");
			});

		return builder.Build();
	}
}
