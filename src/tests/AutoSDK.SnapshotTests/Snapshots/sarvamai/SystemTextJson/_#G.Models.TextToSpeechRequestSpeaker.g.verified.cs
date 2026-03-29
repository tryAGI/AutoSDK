//HintName: G.Models.TextToSpeechRequestSpeaker.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Speaker voice (default: shubh for v3, anushka for v2)
    /// </summary>
    public enum TextToSpeechRequestSpeaker
    {
        /// <summary>
        /// 
        /// </summary>
        Aayan,
        /// <summary>
        /// 
        /// </summary>
        Aditya,
        /// <summary>
        /// 
        /// </summary>
        Advait,
        /// <summary>
        /// 
        /// </summary>
        Amelia,
        /// <summary>
        /// 
        /// </summary>
        Amit,
        /// <summary>
        /// 
        /// </summary>
        Anand,
        /// <summary>
        /// shubh for v3, anushka for v2)
        /// </summary>
        Anushka,
        /// <summary>
        /// 
        /// </summary>
        Ashutosh,
        /// <summary>
        /// 
        /// </summary>
        Dev,
        /// <summary>
        /// 
        /// </summary>
        Gokul,
        /// <summary>
        /// 
        /// </summary>
        Ishita,
        /// <summary>
        /// 
        /// </summary>
        Kabir,
        /// <summary>
        /// 
        /// </summary>
        Kavitha,
        /// <summary>
        /// 
        /// </summary>
        Kavya,
        /// <summary>
        /// 
        /// </summary>
        Manan,
        /// <summary>
        /// 
        /// </summary>
        Mani,
        /// <summary>
        /// 
        /// </summary>
        Mohit,
        /// <summary>
        /// 
        /// </summary>
        Neha,
        /// <summary>
        /// 
        /// </summary>
        Pooja,
        /// <summary>
        /// 
        /// </summary>
        Priya,
        /// <summary>
        /// 
        /// </summary>
        Rahul,
        /// <summary>
        /// 
        /// </summary>
        Ratan,
        /// <summary>
        /// 
        /// </summary>
        Rehan,
        /// <summary>
        /// 
        /// </summary>
        Ritu,
        /// <summary>
        /// 
        /// </summary>
        Rohan,
        /// <summary>
        /// 
        /// </summary>
        Roopa,
        /// <summary>
        /// 
        /// </summary>
        Rupali,
        /// <summary>
        /// 
        /// </summary>
        Shreya,
        /// <summary>
        /// 
        /// </summary>
        Shruti,
        /// <summary>
        /// shubh for v3, anushka for v2)
        /// </summary>
        Shubh,
        /// <summary>
        /// 
        /// </summary>
        Simran,
        /// <summary>
        /// 
        /// </summary>
        Soham,
        /// <summary>
        /// 
        /// </summary>
        Sophia,
        /// <summary>
        /// 
        /// </summary>
        Suhani,
        /// <summary>
        /// 
        /// </summary>
        Sumit,
        /// <summary>
        /// 
        /// </summary>
        Sunny,
        /// <summary>
        /// 
        /// </summary>
        Tanya,
        /// <summary>
        /// 
        /// </summary>
        Tarun,
        /// <summary>
        /// 
        /// </summary>
        Varun,
        /// <summary>
        /// 
        /// </summary>
        Vijay,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToSpeechRequestSpeakerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToSpeechRequestSpeaker value)
        {
            return value switch
            {
                TextToSpeechRequestSpeaker.Aayan => "aayan",
                TextToSpeechRequestSpeaker.Aditya => "aditya",
                TextToSpeechRequestSpeaker.Advait => "advait",
                TextToSpeechRequestSpeaker.Amelia => "amelia",
                TextToSpeechRequestSpeaker.Amit => "amit",
                TextToSpeechRequestSpeaker.Anand => "anand",
                TextToSpeechRequestSpeaker.Anushka => "anushka",
                TextToSpeechRequestSpeaker.Ashutosh => "ashutosh",
                TextToSpeechRequestSpeaker.Dev => "dev",
                TextToSpeechRequestSpeaker.Gokul => "gokul",
                TextToSpeechRequestSpeaker.Ishita => "ishita",
                TextToSpeechRequestSpeaker.Kabir => "kabir",
                TextToSpeechRequestSpeaker.Kavitha => "kavitha",
                TextToSpeechRequestSpeaker.Kavya => "kavya",
                TextToSpeechRequestSpeaker.Manan => "manan",
                TextToSpeechRequestSpeaker.Mani => "mani",
                TextToSpeechRequestSpeaker.Mohit => "mohit",
                TextToSpeechRequestSpeaker.Neha => "neha",
                TextToSpeechRequestSpeaker.Pooja => "pooja",
                TextToSpeechRequestSpeaker.Priya => "priya",
                TextToSpeechRequestSpeaker.Rahul => "rahul",
                TextToSpeechRequestSpeaker.Ratan => "ratan",
                TextToSpeechRequestSpeaker.Rehan => "rehan",
                TextToSpeechRequestSpeaker.Ritu => "ritu",
                TextToSpeechRequestSpeaker.Rohan => "rohan",
                TextToSpeechRequestSpeaker.Roopa => "roopa",
                TextToSpeechRequestSpeaker.Rupali => "rupali",
                TextToSpeechRequestSpeaker.Shreya => "shreya",
                TextToSpeechRequestSpeaker.Shruti => "shruti",
                TextToSpeechRequestSpeaker.Shubh => "shubh",
                TextToSpeechRequestSpeaker.Simran => "simran",
                TextToSpeechRequestSpeaker.Soham => "soham",
                TextToSpeechRequestSpeaker.Sophia => "sophia",
                TextToSpeechRequestSpeaker.Suhani => "suhani",
                TextToSpeechRequestSpeaker.Sumit => "sumit",
                TextToSpeechRequestSpeaker.Sunny => "sunny",
                TextToSpeechRequestSpeaker.Tanya => "tanya",
                TextToSpeechRequestSpeaker.Tarun => "tarun",
                TextToSpeechRequestSpeaker.Varun => "varun",
                TextToSpeechRequestSpeaker.Vijay => "vijay",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToSpeechRequestSpeaker? ToEnum(string value)
        {
            return value switch
            {
                "aayan" => TextToSpeechRequestSpeaker.Aayan,
                "aditya" => TextToSpeechRequestSpeaker.Aditya,
                "advait" => TextToSpeechRequestSpeaker.Advait,
                "amelia" => TextToSpeechRequestSpeaker.Amelia,
                "amit" => TextToSpeechRequestSpeaker.Amit,
                "anand" => TextToSpeechRequestSpeaker.Anand,
                "anushka" => TextToSpeechRequestSpeaker.Anushka,
                "ashutosh" => TextToSpeechRequestSpeaker.Ashutosh,
                "dev" => TextToSpeechRequestSpeaker.Dev,
                "gokul" => TextToSpeechRequestSpeaker.Gokul,
                "ishita" => TextToSpeechRequestSpeaker.Ishita,
                "kabir" => TextToSpeechRequestSpeaker.Kabir,
                "kavitha" => TextToSpeechRequestSpeaker.Kavitha,
                "kavya" => TextToSpeechRequestSpeaker.Kavya,
                "manan" => TextToSpeechRequestSpeaker.Manan,
                "mani" => TextToSpeechRequestSpeaker.Mani,
                "mohit" => TextToSpeechRequestSpeaker.Mohit,
                "neha" => TextToSpeechRequestSpeaker.Neha,
                "pooja" => TextToSpeechRequestSpeaker.Pooja,
                "priya" => TextToSpeechRequestSpeaker.Priya,
                "rahul" => TextToSpeechRequestSpeaker.Rahul,
                "ratan" => TextToSpeechRequestSpeaker.Ratan,
                "rehan" => TextToSpeechRequestSpeaker.Rehan,
                "ritu" => TextToSpeechRequestSpeaker.Ritu,
                "rohan" => TextToSpeechRequestSpeaker.Rohan,
                "roopa" => TextToSpeechRequestSpeaker.Roopa,
                "rupali" => TextToSpeechRequestSpeaker.Rupali,
                "shreya" => TextToSpeechRequestSpeaker.Shreya,
                "shruti" => TextToSpeechRequestSpeaker.Shruti,
                "shubh" => TextToSpeechRequestSpeaker.Shubh,
                "simran" => TextToSpeechRequestSpeaker.Simran,
                "soham" => TextToSpeechRequestSpeaker.Soham,
                "sophia" => TextToSpeechRequestSpeaker.Sophia,
                "suhani" => TextToSpeechRequestSpeaker.Suhani,
                "sumit" => TextToSpeechRequestSpeaker.Sumit,
                "sunny" => TextToSpeechRequestSpeaker.Sunny,
                "tanya" => TextToSpeechRequestSpeaker.Tanya,
                "tarun" => TextToSpeechRequestSpeaker.Tarun,
                "varun" => TextToSpeechRequestSpeaker.Varun,
                "vijay" => TextToSpeechRequestSpeaker.Vijay,
                _ => null,
            };
        }
    }
}