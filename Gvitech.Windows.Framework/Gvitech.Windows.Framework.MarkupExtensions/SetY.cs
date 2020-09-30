using Mmc.Windows.Design;
using Mmc.Windows.Framework.Utils;
using System;
using System.Windows.Data;
using System.Windows.Markup;

namespace Mmc.Windows.Framework.MarkupExtensions
{
	[MarkupExtensionReturnType(typeof(double))]
	public class SetY : MarkupExtension
	{
		[ConstructorArgument("value")]
		public object Value
		{
			get;
			set;
		}

		public SetY(object value)
		{
			this.Value = value;
		}

		public override object ProvideValue(IServiceProvider serviceProvider)
		{
			double y = (double)(this.Value as Binding).Source;
			return Singleton<ScreenHelper>.Instance.GetY(y);
		}
	}
}
