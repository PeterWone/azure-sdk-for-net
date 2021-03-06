// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    public partial class PreAuthorizedApplicationExtension : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Conditions != null)
            {
                writer.WritePropertyName("conditions");
                writer.WriteStartArray();
                foreach (var item in Conditions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static PreAuthorizedApplicationExtension DeserializePreAuthorizedApplicationExtension(JsonElement element)
        {
            IList<string> conditions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("conditions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    conditions = array;
                    continue;
                }
            }
            return new PreAuthorizedApplicationExtension(conditions);
        }
    }
}
