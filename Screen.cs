using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fasad_dll
{
    /// <summary>
    /// экран
    /// </summary>
    public class Screen
    {
        private string description;

        /// <summary>
        /// Initializes a new instance of the <see cref="Screen"/> class.
        /// </summary>
        /// <param name="description">The description.</param>
        public Screen(string description)
        {
            this.description = description;
        }

        /// <summary>
        /// Ups this instance.
        /// </summary>
        public void up()
        {
            Console.WriteLine(description + " going up");
        }

        /// <summary>
        /// Downs this instance.
        /// </summary>
        public void down()
        {
            Console.WriteLine(description + " going down");
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
