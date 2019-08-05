using System;
using System.Windows.Forms;

public class MyWinForm:Form
{
	public static void Main() {
		Application.Run(new MyWinForm());
	}

	public MyWinForm() {
		Text = "My Windows Form";
	}

}
