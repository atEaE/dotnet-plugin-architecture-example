using Xunit;

namespace Test_FirstPlugin
{
    public class FirstPluginTest
    {
        private FirstPlugin.FirstPlugin plugin;

        /// <summary>
        /// Test init.
        /// </summary>
        public FirstPluginTest()
        {
            plugin = new FirstPlugin.FirstPlugin();
        }

        [Fact(DisplayName = "PropertyTest: Name")]
        public void PropertyTest_Name()
        {
            var expect = "First";
            var actual = plugin.Name;
            Assert.Equal(expect, actual);
        }
    }
}
