//HintName: G.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApiProjectsTasksAssigneesCreateRequestFiltersItemOperatorJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator>
    {
        /// <inheritdoc />
        public override global::G.ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator existingValue,
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
                        return global::G.ApiProjectsTasksAssigneesCreateRequestFiltersItemOperatorExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ApiProjectsTasksAssigneesCreateRequestFiltersItemOperatorExtensions.ToValueString(value));
        }
    }
}
