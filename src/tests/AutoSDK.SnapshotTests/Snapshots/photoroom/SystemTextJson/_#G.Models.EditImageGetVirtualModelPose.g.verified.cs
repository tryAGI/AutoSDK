//HintName: G.Models.EditImageGetVirtualModelPose.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: random
    /// </summary>
    public enum EditImageGetVirtualModelPose
    {
        /// <summary>
        /// 
        /// </summary>
        x34turn,
        /// <summary>
        /// 
        /// </summary>
        Adjustingclothing,
        /// <summary>
        /// 
        /// </summary>
        Back,
        /// <summary>
        /// 
        /// </summary>
        Crossedarms,
        /// <summary>
        /// 
        /// </summary>
        Handinpocket,
        /// <summary>
        /// 
        /// </summary>
        Overtheshoulder,
        /// <summary>
        /// 
        /// </summary>
        Playfulspin,
        /// <summary>
        /// 
        /// </summary>
        Powerstance,
        /// <summary>
        /// 
        /// </summary>
        Random,
        /// <summary>
        /// 
        /// </summary>
        Seated,
        /// <summary>
        /// 
        /// </summary>
        Standing,
        /// <summary>
        /// 
        /// </summary>
        Walkingforward,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetVirtualModelPoseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetVirtualModelPose value)
        {
            return value switch
            {
                EditImageGetVirtualModelPose.x34turn => "34turn",
                EditImageGetVirtualModelPose.Adjustingclothing => "adjustingclothing",
                EditImageGetVirtualModelPose.Back => "back",
                EditImageGetVirtualModelPose.Crossedarms => "crossedarms",
                EditImageGetVirtualModelPose.Handinpocket => "handinpocket",
                EditImageGetVirtualModelPose.Overtheshoulder => "overtheshoulder",
                EditImageGetVirtualModelPose.Playfulspin => "playfulspin",
                EditImageGetVirtualModelPose.Powerstance => "powerstance",
                EditImageGetVirtualModelPose.Random => "random",
                EditImageGetVirtualModelPose.Seated => "seated",
                EditImageGetVirtualModelPose.Standing => "standing",
                EditImageGetVirtualModelPose.Walkingforward => "walkingforward",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetVirtualModelPose? ToEnum(string value)
        {
            return value switch
            {
                "34turn" => EditImageGetVirtualModelPose.x34turn,
                "adjustingclothing" => EditImageGetVirtualModelPose.Adjustingclothing,
                "back" => EditImageGetVirtualModelPose.Back,
                "crossedarms" => EditImageGetVirtualModelPose.Crossedarms,
                "handinpocket" => EditImageGetVirtualModelPose.Handinpocket,
                "overtheshoulder" => EditImageGetVirtualModelPose.Overtheshoulder,
                "playfulspin" => EditImageGetVirtualModelPose.Playfulspin,
                "powerstance" => EditImageGetVirtualModelPose.Powerstance,
                "random" => EditImageGetVirtualModelPose.Random,
                "seated" => EditImageGetVirtualModelPose.Seated,
                "standing" => EditImageGetVirtualModelPose.Standing,
                "walkingforward" => EditImageGetVirtualModelPose.Walkingforward,
                _ => null,
            };
        }
    }
}