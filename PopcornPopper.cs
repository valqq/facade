using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fasad_dll
{
    /// <summary>
    /// аппарат для приготовления попкорна
    /// </summary>
    public class PopcornPopper
    {
        private string description;

        /// <summary>
        /// Initializes a new instance of the <see cref="PopcornPopper"/> class.
        /// </summary>
        /// <param name="description">The description.</param>
        public PopcornPopper(string description)
        {
            this.description = description;
        }

        /// <summary>
        /// Ons this instance.
        /// </summary>
        public void on()
        {
            Console.WriteLine(description + " on");
        }

        /// <summary>
        /// Offs this instance.
        /// </summary>
        public void off()
        {
            Console.WriteLine(description + " off");
        }

        /// <summary>
        /// Pops this instance.
        /// </summary>
        public void pop()
        {
            Console.WriteLine(description + " popping popcorn!");
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return description;
        }
    }
}
