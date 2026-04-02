//HintName: G.JsonConverters.ChartsItem2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChartsItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChartsItem2>
    {
        /// <inheritdoc />
        public override global::G.ChartsItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PatchConvAIDashboardSettingsRequestChartDiscriminator>(ref readerCopy, options);

            global::G.DashboardCallSuccessChartModel? callSuccess = default;
            if (discriminator?.Type == global::G.PatchConvAIDashboardSettingsRequestChartDiscriminatorType.CallSuccess)
            {
                callSuccess = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DashboardCallSuccessChartModel>(ref reader, options);
            }
            global::G.DashboardCriteriaChartModel? criteria = default;
            if (discriminator?.Type == global::G.PatchConvAIDashboardSettingsRequestChartDiscriminatorType.Criteria)
            {
                criteria = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DashboardCriteriaChartModel>(ref reader, options);
            }
            global::G.DashboardDataCollectionChartModel? dataCollection = default;
            if (discriminator?.Type == global::G.PatchConvAIDashboardSettingsRequestChartDiscriminatorType.DataCollection)
            {
                dataCollection = global::System.Text.Json.JsonSerializer.Deserialize<global::G.DashboardDataCollectionChartModel>(ref reader, options);
            }

            var __value = new global::G.ChartsItem2(
                discriminator?.Type,
                callSuccess,

                criteria,

                dataCollection
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChartsItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsCallSuccess)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CallSuccess, typeof(global::G.DashboardCallSuccessChartModel), options);
            }
            else if (value.IsCriteria)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Criteria, typeof(global::G.DashboardCriteriaChartModel), options);
            }
            else if (value.IsDataCollection)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DataCollection, typeof(global::G.DashboardDataCollectionChartModel), options);
            }
        }
    }
}