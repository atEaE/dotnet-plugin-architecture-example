using System;
using Xunit;

namespace Test_SecondPlugin
{
    public class SecondPluginTest
    {
        private SecondPlugin.SecondPlugin plugin;

        /// <summary>
        /// Test init.
        /// </summary>
        public SecondPluginTest()
        {
            plugin = new SecondPlugin.SecondPlugin();
        }

        [Fact(DisplayName = "PropertyTest: Name")]
        public void PropertyTest_Name()
        {
            var expect = "Second";
            var actual = plugin.Name;
            Assert.Equal(expect, actual);
        }
    }
}
