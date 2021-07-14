using AssemblyOne;
using System;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            MotorcyclePublic moto = new MotorcyclePublic();
            //private - элемент доступен только в том типе, в котором определен
            //ushort maxSpeedPrivate = moto.maxSpeedPrivate;
            //string vinNumberPrivate = moto.vinNumberPrivate;
            //int odometerPrivate = moto.odometerPrivate;
            //moto.StartEnginePrivate();

            ushort maxSpeedPublic = MotorcyclePublic.maxSpeedPublic;//обращение на уровне класса т.к. "const" статическое поле
            string vinNumberPublic = moto.vinNumberPublic;
            int odometerPublic = moto.odometerPublic;
            moto.StartEnginePublic();

            //protected - элемент доступен в типе, в котором определен, и в наследниках этого типа (в сборке где описан и других сборках)
            //ushort maxSpeedProtected = moto.maxSpeedProtected;
            //string vinNumberProtected = moto.vinNumberProtected;
            //int odometerProtected = moto.odometerProtected;
            //moto.StartEngineProtected();

            //internal - элемент доступен только в той сборке где описан
            //ushort maxSpeedInternal = moto.maxSpeedInternal;//обращение на уровне класса т.к. "const" статическое поле
            //string vinNumberInternal = moto.vinNumberInternal;
            //int odometerInternal = moto.odometerInternal;
            //moto.StartEngineInternal();

            //protected internal - вне сборки где описан элемент доступен только в наследниках типа
            //ushort maxSpeedProtectedInternal = moto.maxSpeedProtectedInternal;//обращение на уровне класса т.к. "const" статическое поле
            //string vinNumberProtectedInternal = moto.vinNumberProtectedInternal;
            //int odometerProtectedInternal = moto.odometerProtectedInternal;
            //moto.StartEngineProtectedInternal();

            //private protected - элемент доступен в типе, в котором определен, и в наследниках этого типа (только в сборке где описан)
            //ushort maxSpeedPrivateProtected = moto.maxSpeedPrivateProtected;
            //string vinNumberPrivateProtected = moto.vinNumberPrivateProtected;
            //int odometerPrivateProtected = moto.odometerPrivateProtected;
            //moto.StartEnginePrivateProtected();

            SportBike sportBike = new SportBike();
            //private - элемент доступен только в том типе, в котором определен
            //ushort maxSpeedSportPrivate = sportBike.maxSpeedPrivate;
            //string vinNumberSportPrivate = sportBike.vinNumberPrivate;
            //int odometerSportPrivate = sportBike.odometerPrivate;
            //sportBike.StartEnginePrivate();

            ushort maxSpeedSportPublic = SportBike.maxSpeedPublic;//обращение на уровне класса т.к. "const" статическое поле
            string vinNumberSportPublic = sportBike.vinNumberPublic;
            int odometerSportPublic = sportBike.odometerPublic;
            sportBike.StartEnginePublic();

            //protected - элемент доступен в типе, в котором определен, и в наследниках этого типа (в сборке где описан и других сборках)
            //ushort maxSpeedSportProtected = sportBike.maxSpeedProtected;
            //string vinNumberSportProtected = sportBike.vinNumberProtected;
            //int odometerSportProtected = sportBike.odometerProtected;
            //sportBike.StartEngineProtected();

            //internal - элемент доступен только в той сборке где описан
            //ushort maxSpeedSportInternal = sportBike.maxSpeedInternal;//обращение на уровне класса т.к. "const" статическое поле
            //string vinNumberSportInternal = sportBike.vinNumberInternal;
            //int odometerSportInternal = sportBike.odometerInternal;
            //sportBike.StartEngineInternal();

            //protected internal - вне сборки где описан элемент доступен только в наследниках типа
            //ushort maxSpeedSportProtectedInternal = sportBike.maxSpeedProtectedInternal;//обращение на уровне класса т.к. "const" статическое поле
            //string vinNumberSportProtectedInternal = sportBike.vinNumberProtectedInternal;
            //int odometerSportProtectedInternal = sportBike.odometerProtectedInternal;
            //sportBike.StartEngineProtectedInternal();

            //private protected - элемент доступен в типе, в котором определен, и в наследниках этого типа (только в сборке где описан)
            //ushort maxSpeedSportPrivateProtected = sportBike.maxSpeedPrivateProtected;
            //string vinNumberSportPrivateProtected = sportBike.vinNumberPrivateProtected;
            //int odometerSportPrivateProtected = sportBike.odometerPrivateProtected;
            //sportBike.StartEnginePrivateProtected();
        }
    }
    class SportBike : MotorcyclePublic
    {
        //private protected - элемент доступен в типе, в котором определен, и в наследниках этого типа (только в сборке где описан)
        //ushort maxSpeedSportPrivateProtected = maxSpeedPrivateProtected;
        //string vinNumberSportPrivateProtected1 = vinNumberPrivateProtected;
        //int odometerSportPrivateProtected1 = odometerPrivateProtected;

        //ushort maxSpeedSportPrivate = maxSpeedPrivate;
        //string vinNumberSportPrivate = vinNumberPrivate;
        //int odometerSportPrivate = odometerPrivate;

        ushort maxSpeedSportProtectedInternal = maxSpeedProtectedInternal;
        internal SportBike()
        {
            //private protected - элемент доступен в типе, в котором определен, и в наследниках этого типа (только в сборке где описан)
            //StartEnginePrivateProtected();

            //private - элемент доступен только в том типе, в котором определен
            //StartEnginePrivate();

            string vinNumberSportProtectedInternal = vinNumberProtectedInternal;
            int odometerSportProtectedInternal = odometerProtectedInternal;
            StartEngineProtectedInternal();
        }
    }
}
