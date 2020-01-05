using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Web.UI;

namespace MyWebCtrls
{
	public class UserControl : System.Web.UI.UserControl
	{
		protected override void Construct()
		{
			base.Construct();
			// page == null here
		}
		protected override void FrameworkInitialize()
		{
			base.FrameworkInitialize();

			string content = String.Empty;
			Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(GetType(), GetType().Name + ".ascx");
			using (StreamReader reader = new StreamReader(stream))
			{
				content = reader.ReadToEnd();
			}
			Control userControl = Page.ParseControl(content);
			this.Controls.Add(userControl);
		}
	}
}
