//HintName: G.Models.TextToSpeechRequestSpeaker.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Speaker voice (default: shubh for v3, anushka for v2)
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextToSpeechRequestSpeaker
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="aayan")]
        Aayan,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="aditya")]
        Aditya,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="advait")]
        Advait,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="amelia")]
        Amelia,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="amit")]
        Amit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anand")]
        Anand,
        /// <summary>
        /// shubh for v3, anushka for v2)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anushka")]
        Anushka,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ashutosh")]
        Ashutosh,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dev")]
        Dev,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gokul")]
        Gokul,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ishita")]
        Ishita,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="kabir")]
        Kabir,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="kavitha")]
        Kavitha,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="kavya")]
        Kavya,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="manan")]
        Manan,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mani")]
        Mani,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mohit")]
        Mohit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neha")]
        Neha,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pooja")]
        Pooja,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="priya")]
        Priya,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rahul")]
        Rahul,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ratan")]
        Ratan,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rehan")]
        Rehan,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ritu")]
        Ritu,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rohan")]
        Rohan,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="roopa")]
        Roopa,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rupali")]
        Rupali,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shreya")]
        Shreya,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shruti")]
        Shruti,
        /// <summary>
        /// shubh for v3, anushka for v2)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shubh")]
        Shubh,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="simran")]
        Simran,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="soham")]
        Soham,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sophia")]
        Sophia,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="suhani")]
        Suhani,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sumit")]
        Sumit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sunny")]
        Sunny,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tanya")]
        Tanya,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tarun")]
        Tarun,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="varun")]
        Varun,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vijay")]
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