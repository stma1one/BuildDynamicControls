namespace BuildDynamicControls;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		InitializeControls();
	}

	private void InitializeControls()
	{
		StackLayout stackLayout = new StackLayout
		{
			Orientation = StackOrientation.Vertical,
			BackgroundColor = Color.FromArgb("#210222"),
			Margin = new Thickness(10, 10, 10, 10),
			Spacing = 25
		};

		stackLayout.Add(new Label
		{
			Text = "שלום! אני תווית שנוצרה באופן דינאמי",
			TextColor = Color.FromArgb("#FDDB01"),
			FontSize = 20,
			Padding = new Thickness(10, 10, 10, 10),
			HorizontalOptions = LayoutOptions.Center

		});

		Image img = new Image() { Source = "https://i1.wp.com/holoniafans.com/wp-content/uploads/2019/04/cropped-favicon.png", HeightRequest = 300, WidthRequest = 300 };
		stackLayout.Add(img);
		Button btn = new Button
		{ 
			Text = "ספור אותי",
			FontSize=20,
			TextColor= Color.FromArgb("#56265A"),
			BackgroundColor=Color.FromArgb("#E9D22E"),
			BorderColor =Color.FromArgb("#FBF8FD"),
			BorderWidth=1.5,
			Margin = new Thickness(30) 
		};
		btn.Clicked += (sender, e) =>
		{
			count++;

			if (count == 1)
				((Button)sender).Text = $"לחצו פעם אחת";
			else
				((Button)sender).Text = $"נלחצתי {count} פעמים";
		};
		stackLayout.Add(btn);

		this.Content = stackLayout;

	}


}

