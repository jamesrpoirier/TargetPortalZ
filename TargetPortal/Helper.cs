using System;
using System.IO;
using System.Reflection;
using UnityEngine;

namespace TargetPortal;

public static class Helper
{
	private static byte[] ReadEmbeddedFileBytes(string name)
	{
		using MemoryStream stream = new();
		Assembly.GetExecutingAssembly().GetManifestResourceStream("TargetPortal." + name)?.CopyTo(stream);
		return stream.ToArray();
	}

	private static Texture2D loadTexture(string name)
	{
		Texture2D texture = new(0, 0);
		Type imageConversion = Type.GetType("UnityEngine.ImageConversion, UnityEngine.ImageConversionModule")
			?? throw new InvalidOperationException("Unity image conversion module is unavailable.");
		MethodInfo loadImage = imageConversion.GetMethod("LoadImage", new[] { typeof(Texture2D), typeof(byte[]) })
			?? throw new MissingMethodException("UnityEngine.ImageConversion.LoadImage(Texture2D, byte[])");
		loadImage.Invoke(null, new object[] { texture, ReadEmbeddedFileBytes(name) });
		return texture;
	}

	public static Sprite loadSprite(string name, int width, int height) => Sprite.Create(loadTexture(name), new Rect(0, 0, width, height), Vector2.zero);
}
