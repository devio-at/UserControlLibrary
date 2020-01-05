using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Reflection;

namespace MyWebCtrls
{
	public partial class myLabel : UserControl
	{
		protected Label label;

		protected override void FrameworkInitialize()
		{
			base.FrameworkInitialize();

			label = this.FindControl("label") as Label;
		}
	}
}