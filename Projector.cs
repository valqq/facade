using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fasad_dll
{
    /// <summary>
    /// проектор
    /// </summary>
    public class Projector
    {
        private string description;
        private DvdPlayer dvdPlayer;

        /// <summary>
        /// Initializes a new instance of the <see cref="Projector"/> class.
        /// </summary>
        /// <param name="description">The description.</param>
        /// <param name="dvdPlayer">The DVD player.</param>
        public Projector(string description, DvdPlayer dvdPlayer)
        {
            this.description = description;
            this.dvdPlayer = dvdPlayer;
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
        /// Wides the screen mode.
        /// </summary>
        public void wideScreenMode()
        {
            Console.WriteLine(description + " in widescreen mode (16x9 aspect ratio)");
        }

        /// <summary>
        /// Tvs the mode.
        /// </summary>
        public void tvMode()
        {
            Console.WriteLine(description + " in tv mode (4x3 aspect ratio)");
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
