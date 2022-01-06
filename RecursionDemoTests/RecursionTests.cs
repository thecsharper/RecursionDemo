using System;

using Xunit;

using RecursionDemo;

namespace RecursionDemoTests
{
    public class RecursionTests
    {
        [Fact]
        public void Recurse_correct_input_completes()
        {
            var input = "This is a really really really-really really long string.. :)";

            Program.Recurse(input, 7);
        }

        [Fact]
        public void Recurse_incorrect_input_throws_argumentexception()
        {
            var input = "a";

            Assert.Throws<ArgumentOutOfRangeException>(() => Program.Recurse(input, 7));
        }
    }
}