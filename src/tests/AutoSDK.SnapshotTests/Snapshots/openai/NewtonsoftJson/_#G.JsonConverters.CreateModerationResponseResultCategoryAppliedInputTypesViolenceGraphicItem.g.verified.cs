//HintName: G.JsonConverters.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItemJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem>
    {
        /// <inheritdoc />
        public override global::G.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem existingValue,
            bool hasExistingValue,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            reader = reader ?? throw new global::System.ArgumentNullException(nameof(reader));

            if (hasExistingValue)
            {
                return existingValue;
            }

            switch (reader.TokenType)
            {
                case global::Newtonsoft.Json.JsonToken.String:
                {
                    var stringValue = reader.Value as string ?? reader.ReadAsString();
                    if (stringValue != null)
                    {
                        return global::G.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItemExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItem value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CreateModerationResponseResultCategoryAppliedInputTypesViolenceGraphicItemExtensions.ToValueString(value));
        }
    }
}
