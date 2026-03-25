using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "18.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (resourceMan == null)
			{
				ResourceManager temp = new ResourceManager("FarmaciaPresentacion.Properties.Resources", typeof(Resources).Assembly);
				resourceMan = temp;
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static byte[] pharmacy_drugstore_medicine_medical_icon_266389
	{
		get
		{
			object obj = ResourceManager.GetObject("pharmacy_drugstore_medicine_medical_icon_266389", resourceCulture);
			return (byte[])obj;
		}
	}

	internal static Bitmap preview_search_find_locate_1551
	{
		get
		{
			object obj = ResourceManager.GetObject("preview_search_find_locate_1551", resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap simbolo_de_interfaz_de_archivo_de_busqueda
	{
		get
		{
			object obj = ResourceManager.GetObject("simbolo-de-interfaz-de-archivo-de-busqueda", resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap simbolo_de_interfaz_de_archivo_de_busqueda1
	{
		get
		{
			object obj = ResourceManager.GetObject("simbolo-de-interfaz-de-archivo-de-busqueda1", resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal Resources()
	{
	}
}
