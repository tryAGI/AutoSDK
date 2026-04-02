//HintName: G.JsonConverters.Expression.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ExpressionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Expression>
    {
        /// <inheritdoc />
        public override global::G.Expression Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            var __score1 = 0;
            var __score2 = 0;
            var __score3 = 0;
            if (__jsonProps.Contains("geo_distance")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("datetime")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("datetime_key")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("mult")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("sum")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("neg")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("abs")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("div")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("sqrt")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("pow")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("exp")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("log10")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("ln")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("lin_decay")) __score16++;
            var __score17 = 0;
            if (__jsonProps.Contains("exp_decay")) __score17++;
            var __score18 = 0;
            if (__jsonProps.Contains("gauss_decay")) __score18++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }
            if (__score13 > __bestScore) { __bestScore = __score13; __bestIndex = 13; }
            if (__score14 > __bestScore) { __bestScore = __score14; __bestIndex = 14; }
            if (__score15 > __bestScore) { __bestScore = __score15; __bestIndex = 15; }
            if (__score16 > __bestScore) { __bestScore = __score16; __bestIndex = 16; }
            if (__score17 > __bestScore) { __bestScore = __score17; __bestIndex = 17; }
            if (__score18 > __bestScore) { __bestScore = __score18; __bestIndex = 18; }

            float? expressionVariant1 = default;
            string? expressionVariant2 = default;
            global::G.Condition? condition = default;
            global::G.GeoDistance? geoDistance = default;
            global::G.DatetimeExpression? datetime = default;
            global::G.DatetimeKeyExpression? datetimeKey = default;
            global::G.MultExpression? mult = default;
            global::G.SumExpression? sum = default;
            global::G.NegExpression? neg = default;
            global::G.AbsExpression? abs = default;
            global::G.DivExpression? div = default;
            global::G.SqrtExpression? sqrt = default;
            global::G.PowExpression? pow = default;
            global::G.ExpExpression? exp = default;
            global::G.Log10Expression? log10 = default;
            global::G.LnExpression? ln = default;
            global::G.LinDecayExpression? linDecay = default;
            global::G.ExpDecayExpression? expDecay = default;
            global::G.GaussDecayExpression? gaussDecay = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(float), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<float> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(float).Name}");
                        expressionVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                        expressionVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Condition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Condition> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Condition).Name}");
                        condition = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GeoDistance), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GeoDistance> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GeoDistance).Name}");
                        geoDistance = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DatetimeExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DatetimeExpression> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DatetimeExpression).Name}");
                        datetime = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DatetimeKeyExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DatetimeKeyExpression> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DatetimeKeyExpression).Name}");
                        datetimeKey = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MultExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MultExpression> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MultExpression).Name}");
                        mult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SumExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SumExpression> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SumExpression).Name}");
                        sum = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NegExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NegExpression> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NegExpression).Name}");
                        neg = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AbsExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AbsExpression> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AbsExpression).Name}");
                        abs = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DivExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DivExpression> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DivExpression).Name}");
                        div = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SqrtExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SqrtExpression> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SqrtExpression).Name}");
                        sqrt = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 12)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PowExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PowExpression> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PowExpression).Name}");
                        pow = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 13)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ExpExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ExpExpression> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ExpExpression).Name}");
                        exp = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 14)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Log10Expression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Log10Expression> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Log10Expression).Name}");
                        log10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 15)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LnExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LnExpression> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LnExpression).Name}");
                        ln = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 16)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LinDecayExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LinDecayExpression> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LinDecayExpression).Name}");
                        linDecay = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 17)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ExpDecayExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ExpDecayExpression> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ExpDecayExpression).Name}");
                        expDecay = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 18)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GaussDecayExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GaussDecayExpression> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GaussDecayExpression).Name}");
                        gaussDecay = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (expressionVariant1 == null && expressionVariant2 == null && condition == null && geoDistance == null && datetime == null && datetimeKey == null && mult == null && sum == null && neg == null && abs == null && div == null && sqrt == null && pow == null && exp == null && log10 == null && ln == null && linDecay == null && expDecay == null && gaussDecay == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(float), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<float> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(float).Name}");
                    expressionVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                    expressionVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Condition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Condition> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Condition).Name}");
                    condition = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GeoDistance), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GeoDistance> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GeoDistance).Name}");
                    geoDistance = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DatetimeExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DatetimeExpression> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DatetimeExpression).Name}");
                    datetime = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DatetimeKeyExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DatetimeKeyExpression> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DatetimeKeyExpression).Name}");
                    datetimeKey = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MultExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MultExpression> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MultExpression).Name}");
                    mult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SumExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SumExpression> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SumExpression).Name}");
                    sum = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NegExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NegExpression> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NegExpression).Name}");
                    neg = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AbsExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AbsExpression> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AbsExpression).Name}");
                    abs = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DivExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DivExpression> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DivExpression).Name}");
                    div = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SqrtExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SqrtExpression> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SqrtExpression).Name}");
                    sqrt = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PowExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PowExpression> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PowExpression).Name}");
                    pow = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ExpExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ExpExpression> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ExpExpression).Name}");
                    exp = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Log10Expression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Log10Expression> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Log10Expression).Name}");
                    log10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LnExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LnExpression> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LnExpression).Name}");
                    ln = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LinDecayExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LinDecayExpression> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LinDecayExpression).Name}");
                    linDecay = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ExpDecayExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ExpDecayExpression> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ExpDecayExpression).Name}");
                    expDecay = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GaussDecayExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GaussDecayExpression> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GaussDecayExpression).Name}");
                    gaussDecay = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.Expression(
                expressionVariant1,

                expressionVariant2,

                condition,

                geoDistance,

                datetime,

                datetimeKey,

                mult,

                sum,

                neg,

                abs,

                div,

                sqrt,

                pow,

                exp,

                log10,

                ln,

                linDecay,

                expDecay,

                gaussDecay
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Expression value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsExpressionVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(float), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<float> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(float).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExpressionVariant1!.Value, typeInfo);
            }
            else if (value.IsExpressionVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExpressionVariant2!, typeInfo);
            }
            else if (value.IsCondition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Condition), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Condition> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Condition).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Condition!.Value, typeInfo);
            }
            else if (value.IsGeoDistance)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GeoDistance), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GeoDistance?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GeoDistance).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GeoDistance!, typeInfo);
            }
            else if (value.IsDatetime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DatetimeExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DatetimeExpression?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DatetimeExpression).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Datetime!, typeInfo);
            }
            else if (value.IsDatetimeKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DatetimeKeyExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DatetimeKeyExpression?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DatetimeKeyExpression).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DatetimeKey!, typeInfo);
            }
            else if (value.IsMult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MultExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MultExpression?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MultExpression).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mult!, typeInfo);
            }
            else if (value.IsSum)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SumExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SumExpression?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SumExpression).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sum!, typeInfo);
            }
            else if (value.IsNeg)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NegExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NegExpression?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NegExpression).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Neg!, typeInfo);
            }
            else if (value.IsAbs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AbsExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AbsExpression?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AbsExpression).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Abs!, typeInfo);
            }
            else if (value.IsDiv)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DivExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DivExpression?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DivExpression).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Div!, typeInfo);
            }
            else if (value.IsSqrt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SqrtExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SqrtExpression?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SqrtExpression).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sqrt!, typeInfo);
            }
            else if (value.IsPow)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PowExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PowExpression?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PowExpression).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pow!, typeInfo);
            }
            else if (value.IsExp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ExpExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ExpExpression?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ExpExpression).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Exp!, typeInfo);
            }
            else if (value.IsLog10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Log10Expression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Log10Expression?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Log10Expression).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Log10!, typeInfo);
            }
            else if (value.IsLn)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LnExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LnExpression?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LnExpression).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ln!, typeInfo);
            }
            else if (value.IsLinDecay)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LinDecayExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LinDecayExpression?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LinDecayExpression).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LinDecay!, typeInfo);
            }
            else if (value.IsExpDecay)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ExpDecayExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ExpDecayExpression?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ExpDecayExpression).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExpDecay!, typeInfo);
            }
            else if (value.IsGaussDecay)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GaussDecayExpression), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GaussDecayExpression?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GaussDecayExpression).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GaussDecay!, typeInfo);
            }
        }
    }
}