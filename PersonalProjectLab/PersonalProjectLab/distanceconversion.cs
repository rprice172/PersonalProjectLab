using System;
namespace PersonalProjectLab
{
    public class distanceconversion
    {

        public distanceconversion()
        { }
            public double calculatemeters(int feet)
            {
                double meters = 0;

                meters = (feet * .3048);

                return meters;
            }

            public double calculatekilometers(int miles)
            {
                double kilometers = 0;

                kilometers = (miles * 1.609344);

                return kilometers;

            }
    }
}
