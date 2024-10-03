using System.Text.RegularExpressions;
using SharpYaml.Serialization;

namespace AutoSDK.Helpers;

public static class OpenApi31Support
{
    public static bool IsOpenApi31(string input)
    {
        input = input ?? throw new ArgumentNullException(nameof(input));
        
        return input.Contains("openapi: 3.1.0") ||
               input.Contains("\"openapi\":\"3.1.0\"");
    }
    
    public static string ConvertToOpenApi30(string input)
    {
        input = input ?? throw new ArgumentNullException(nameof(input));
        
        if (input.StartsWith("{", StringComparison.Ordinal))
        {
            return ConvertJsonToOpenApi30(input);
        }

        return ConvertYamlToOpenApi30(input);
    }
    
    public static string ConvertJsonToOpenApi30(string input)
    {
        input = input ?? throw new ArgumentNullException(nameof(input));
        
        var output = input.Replace("\"openapi\":\"3.1.0\"", "\"openapi\":\"3.0.3\"");
        
        // JSON regex replacements for exclusiveMaximum and exclusiveMinimum
        Regex exclusiveMaximumJsonRegex = new(@"""exclusiveMaximum""\s*:\s*(?<value>[\d\.eE\+\-]+)", RegexOptions.Compiled);
        output = exclusiveMaximumJsonRegex.Replace(output, match =>
        {
            string value = match.Groups["value"].Value;

            return $"\"maximum\": {value}, \"exclusiveMaximum\": true";
        });

        Regex exclusiveMinimumJsonRegex = new(@"""exclusiveMinimum""\s*:\s*(?<value>[\d\.eE\+\-]+)", RegexOptions.Compiled);
        output = exclusiveMinimumJsonRegex.Replace(output, match =>
        {
            string value = match.Groups["value"].Value;

            return $"\"minimum\": {value}, \"exclusiveMinimum\": true";
        });
        
        return output;
    }
    
    public static string ConvertYamlToOpenApi30(string input)
    {
        input = input ?? throw new ArgumentNullException(nameof(input));
        
        var serializer = new Serializer(new SerializerSettings
        {
            EmitTags = false, // Avoid emitting tags
            EmitDefaultValues = true, // Ensure all values are serialized
            IgnoreUnmatchedProperties = true // Ignore properties that do not match the class
        });
        if (serializer.Deserialize<object>(new StringReader(input)) is not Dictionary<object, object?> yamlObject)
        {
            return input;
        }
        
        ConvertYamlNode(yamlObject);
        
        return serializer.Serialize(yamlObject);
    }
    
    private static void ConvertYamlNode(Dictionary<object, object?> node)
    {
        node = node ?? throw new ArgumentNullException(nameof(node));

        foreach (var entry in new Dictionary<object, object?>(node))
        {
            // Recursively convert child nodes if the value is a dictionary
            if (entry.Value is Dictionary<object, object?> childNode)
            {
                ConvertYamlNode(childNode);
            }
            else if (entry.Value is List<object> listNode)
            {
                // Recursively convert each item in a sequence (list)
                foreach (var item in listNode)
                {
                    if (item is Dictionary<object, object?> listItem)
                    {
                        ConvertYamlNode(listItem);
                    }
                }
            }
            
            var keyString = entry.Key as string;
            if (keyString == "anyOf" &&
                entry.Value is List<object?> anyOfList && anyOfList.Count == 2 &&
                anyOfList.Any(v =>
                    v is Dictionary<object, object?> objects &&
                    objects.ContainsKey("type") &&
                    objects["type"] is null))
            {
                var first = anyOfList[0] as Dictionary<object, object?>;
                var second = anyOfList[1] as Dictionary<object, object?>;
                var firstType = first?.TryGetValue("type", out var firstResult) == true ? firstResult : null;
                var secondType = second?.TryGetValue("type", out var secondResult) == true ? secondResult : null;
                if (secondType == null || 
                    firstType == null)
                {
                    // Replace "anyOf" with "type: string, nullable: true"
                    node[new string("type".ToCharArray())] = firstType ?? secondType;
                    node[new string("nullable".ToCharArray())] = true;
                    if (firstType != null)
                    {
                        foreach (var key in first ?? new Dictionary<object, object?>())
                        {
                            node[key.Key] = key.Value;
                        }
                    }
                    else
                    {
                        foreach (var key in second ?? new Dictionary<object, object?>())
                        {
                            node[key.Key] = key.Value;
                        }
                    }
                    node.Remove(keyString);
                }
            }
            if (keyString == "openapi")
            {
                node[new string("openapi".ToCharArray())] = "3.0.3";
            }
            if (keyString == "exclusiveMinimum" &&
                entry.Value is not bool)
            {
                node[new string("minimum".ToCharArray())] = entry.Value;
                node[new string("exclusiveMinimum".ToCharArray())] = true;
            }
            if (keyString == "exclusiveMaximum" &&
                entry.Value is not bool)
            {
                node[new string("maximum".ToCharArray())] = entry.Value;
                node[new string("exclusiveMaximum".ToCharArray())] = true;
            }
            
            // Identify "type" that is a list containing "string" and "null"
            if (keyString == "type" &&
                entry.Value is List<object?> typeList &&
                typeList.Contains(null))
            {
                // Replace "type" with "string" and add "nullable: true"
                node[new string("type".ToCharArray())] = typeList.First(v => v != null);
                node[new string("nullable".ToCharArray())] = true;
                
                // If there's an "enum", remove the "null" from its values
                if (node.TryGetValue("enum", out var enumValue) && enumValue is List<object?> enumList)
                {
                    node[new string("enum".ToCharArray())] = enumList.Where(v => v != null).ToList();
                }
            }
            
            // Replace "examples" with single "example"
            if (keyString == "examples" &&
                entry.Value is List<object> { Count: > 0 } examplesList)
            {
                node.Remove(keyString);

                node[new string("example".ToCharArray())] = examplesList.First();
            }
            
            // Fix "example" node when "items" is missing and "example" is a list
            if (keyString == "example" &&
                entry.Value is List<object> { Count: > 0 } exampleList &&
                !node.ContainsKey("items"))
            {
                node[new string("example".ToCharArray())] = exampleList.First();
            }
            
            // Identify "const" node for removal and convert to "enum" if "enum" is missing
            if (keyString == "const")
            {
                if (!node.ContainsKey("enum"))
                {
                    node[new string("enum".ToCharArray())] = new List<object?>
                    {
                        entry.Value,
                    };
                }
                node.Remove(keyString);
            }
        }
    }
}