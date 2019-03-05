using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw270219
{
    class Camp
    {
        private readonly int id;

        public int Latitude { get; private set; }

        public int Longitude { get; private set; }

        public int NumberOfPeoples { get; private set; }

        public int NumberOfTents { get; private set; }

        public int NumberOfFlashLights { get; private set; }



        private static int lastCampId = 0;



        public Camp(int latitude, int longitude, int numberOfPeople, int numberOfTents, int numberOfFlashLights)

        {

            this.id = ++lastCampId;

            Latitude = latitude;

            Longitude = longitude;

            NumberOfPeoples = numberOfPeople;

            NumberOfTents = numberOfTents;

            NumberOfFlashLights = numberOfFlashLights;

        }
        public static bool operator ==(Camp camp1, Camp camp2)

        {

            if (ReferenceEquals(camp1, null) && ReferenceEquals(camp2, null))

                return true;

            if (ReferenceEquals(camp1, null) || ReferenceEquals(camp2, null))

                return false;



            return camp1.id == camp2.id;

        }



        public static bool operator !=(Camp camp1, Camp camp2)

        {

            return !(camp1 == camp2);

        }



        public static Camp operator +(Camp camp1, Camp camp2)

        {

            return new Camp((camp1.Latitude + camp2.Latitude) / 2, (camp1.Longitude + camp2.Longitude) / 2,

                camp1.NumberOfPeoples + camp2.NumberOfPeoples, camp1.NumberOfTents + camp2.NumberOfTents,

                camp1.NumberOfFlashLights + camp2.NumberOfFlashLights);

        }



        public static bool operator >(Camp camp1, Camp camp2)

        {

            return camp1.NumberOfPeoples > camp2.NumberOfPeoples;

        }



        public static bool operator <(Camp camp1, Camp camp2)

        {

            return camp1.NumberOfPeoples < camp2.NumberOfPeoples;

        }



        public override int GetHashCode()

        {

            return this.id;

        }



        public override string ToString()

        {

            return $"Camp {id} {Latitude} {Longitude} people: {NumberOfPeoples} flashlights : {NumberOfFlashLights} tents : {NumberOfTents}";

        }



        public override bool Equals(object obj)

        {

            //if (ReferenceEquals(obj, null))

            //    return false;



            Camp other = obj as Camp;

            return this == other;

        }
    }
}