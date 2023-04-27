using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fasad_dll
{
    /// <summary>
    /// освещение
    /// </summary>
    public class TheaterLights
    {
        private string description;

        /// <summary>
        /// Initializes a new instance of the <see cref="TheaterLights"/> class.
        /// </summary>
        /// <param name="description">The description.</param>
        public TheaterLights(string description)
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
        /// Dims the specified level.
        /// </summary>
        /// <param name="level">The level.</param>
        public void dim(int level)
        {
            Console.WriteLine(description + " dimming to " + level + "%");
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
