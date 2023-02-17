using System;
using Microsoft.Xna.Framework;


namespace boss_titles.Util {

    public class RGBA {

        public static readonly RGBA BLACK = new RGBA(0.0, 0.0, 0.0, 1.0);

        public double r {get; private set;}
        public double g {get; private set;}
        public double b {get; private set;}
        public double a {get; private set;}

        public RGBA(double r, double g, double b) : this(r, g, b, 1.0) {}

        public static RGBA HSV(double h, double s, double v) {
            int    hi = (int)Math.Floor(h / 60.0d) % 6;
            double f  = h / 60.0d - Math.Floor(h / 60.0d);
            v         = v * 255.0d;
            double p  = v * (1.0d - s) / 255.0d;
            double q  = v * (1.0d - f * s) / 255.0d;
            double t  = v * (1.0d - (1.0d - f) * s) / 255.0d;
            if (hi == 0) {
                return new RGBA(v, t, p);
            } else if (hi == 1) {
                return new RGBA(q, v, p);
            } else if (hi == 2) {
                return new RGBA(p, v, t);
            } else if (hi == 3) {
                return new RGBA(p, q, v);
            } else if (hi == 4) {
                return new RGBA(t, p, v);
            } else {
                return new RGBA(v, p, q);
            }
        }

        public RGBA(double r, double g, double b, double a) {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }

        public Color IntoColour() {
            return new Color((int)Math.Floor(this.r * 255.0), (int)Math.Floor(this.g * 255.0), (int)Math.Floor(this.b * 255.0), (int)Math.Floor(this.a * 255.0));
        }

        public RGBA Multiply(double value) {
            return new RGBA(this.r * value, this.g * value, this.b * value, this.a * value);
        }

    }

}
