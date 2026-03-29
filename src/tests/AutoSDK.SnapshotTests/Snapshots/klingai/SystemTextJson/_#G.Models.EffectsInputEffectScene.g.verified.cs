//HintName: G.Models.EffectsInputEffectScene.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Effect scene type to apply.
    /// </summary>
    public enum EffectsInputEffectScene
    {
        /// <summary>
        /// 
        /// </summary>
        Christmas,
        /// <summary>
        /// 
        /// </summary>
        DualCharacter,
        /// <summary>
        /// 
        /// </summary>
        Halloween,
        /// <summary>
        /// 
        /// </summary>
        NewYear,
        /// <summary>
        /// 
        /// </summary>
        OldPhotoRestoration,
        /// <summary>
        /// 
        /// </summary>
        SpringFestival,
        /// <summary>
        /// 
        /// </summary>
        Thanksgiving,
        /// <summary>
        /// 
        /// </summary>
        ValentinesDay,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EffectsInputEffectSceneExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EffectsInputEffectScene value)
        {
            return value switch
            {
                EffectsInputEffectScene.Christmas => "christmas",
                EffectsInputEffectScene.DualCharacter => "dual_character",
                EffectsInputEffectScene.Halloween => "halloween",
                EffectsInputEffectScene.NewYear => "new_year",
                EffectsInputEffectScene.OldPhotoRestoration => "old_photo_restoration",
                EffectsInputEffectScene.SpringFestival => "spring_festival",
                EffectsInputEffectScene.Thanksgiving => "thanksgiving",
                EffectsInputEffectScene.ValentinesDay => "valentines_day",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EffectsInputEffectScene? ToEnum(string value)
        {
            return value switch
            {
                "christmas" => EffectsInputEffectScene.Christmas,
                "dual_character" => EffectsInputEffectScene.DualCharacter,
                "halloween" => EffectsInputEffectScene.Halloween,
                "new_year" => EffectsInputEffectScene.NewYear,
                "old_photo_restoration" => EffectsInputEffectScene.OldPhotoRestoration,
                "spring_festival" => EffectsInputEffectScene.SpringFestival,
                "thanksgiving" => EffectsInputEffectScene.Thanksgiving,
                "valentines_day" => EffectsInputEffectScene.ValentinesDay,
                _ => null,
            };
        }
    }
}