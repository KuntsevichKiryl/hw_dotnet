using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    class Motorcycle
    {
        const ushort maxSpeedPrivate = 300;
        public const ushort maxSpeedPublic = 300;
        protected const ushort maxSpeedProtected = 300;
        internal const ushort maxSpeedInternal = 300;
        protected internal const ushort maxSpeedProtectedInternal = 300;
        private protected const ushort maxSpeedPrivateProtected = 300;
        string vinNumberPrivate = "A11111-B222-C333-D444-55555EE";
        public string vinNumberPublic = "A11111-B222-C333-D444-55555EE";
        protected string vinNumberProtected = "A11111-B222-C333-D444-55555EE";
        internal string vinNumberInternal = "A11111-B222-C333-D444-55555EE";
        protected internal string vinNumberProtectedInternal = "A11111-B222-C333-D444-55555EE";
        private protected string vinNumberPrivateProtected = "A11111-B222-C333-D444-55555EE";
        int odometerPrivate = 20000;
        public int odometerPublic = 20000;
        protected int odometerProtected = 20000;
        internal int odometerInternal = 20000;
        protected internal int odometerProtectedInternal = 20000;
        private protected int odometerPrivateProtected = 20000;


        void StartEnginePrivate()
        {
        }
        public void StartEnginePublic()
        {
        }
        protected void StartEngineProtected()
        {
        }
        internal void StartEngineInternal()
        {
        }
        protected internal void StartEngineProtectedInternal()
        {
        }
        private protected void StartEnginePrivateProtected()
        {
        }
    }
    public class MotorcyclePublic
    {
        const ushort maxSpeedPrivate = 300;
        public const ushort maxSpeedPublic = 300;
        protected const ushort maxSpeedProtected = 300;
        internal const ushort maxSpeedInternal = 300;
        protected internal const ushort maxSpeedProtectedInternal = 300;
        private protected const ushort maxSpeedPrivateProtected = 300;
        string vinNumberPrivate = "A11111-B222-C333-D444-55555EE";
        public string vinNumberPublic = "A11111-B222-C333-D444-55555EE";
        protected string vinNumberProtected = "A11111-B222-C333-D444-55555EE";
        internal string vinNumberInternal = "A11111-B222-C333-D444-55555EE";
        protected internal string vinNumberProtectedInternal = "A11111-B222-C333-D444-55555EE";
        private protected string vinNumberPrivateProtected = "A11111-B222-C333-D444-55555EE";
        int odometerPrivate = 20000;
        public int odometerPublic = 20000;
        protected int odometerProtected = 20000;
        internal int odometerInternal = 20000;
        protected internal int odometerProtectedInternal = 20000;
        private protected int odometerPrivateProtected = 20000;

        void StartEnginePrivate()
        {
        }
        public void StartEnginePublic()
        {
        }
        protected void StartEngineProtected()
        {
        }
        internal void StartEngineInternal()
        {
        }
        protected internal void StartEngineProtectedInternal()
        {
        }
        private protected void StartEnginePrivateProtected()
        {
        }
    }
}
