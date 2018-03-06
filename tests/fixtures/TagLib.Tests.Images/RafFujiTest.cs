using NUnit.Framework;

namespace TagLib.Tests.Images
{
	[TestFixture]
	public class RafFujiTest
	{
		[TestCase("fuji.raf", 4288, 2848)]
		[TestCase("canon.cr2", 3888, 2592)]
		public void CheckProperties (string filename, int expectedWidth, int expectedHeight)
		{
			string path = TestPath.Samples + filename;
			var file = File.Create (path);

			Assert.NotNull(file.Properties);
			Assert.AreEqual (expectedWidth, file.Properties.PhotoWidth);
			Assert.AreEqual (expectedHeight, file.Properties.PhotoHeight);
		}
	}
}
