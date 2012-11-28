﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using Mapsui.Geometries;
using Mapsui.Styles;

namespace Mapsui.Providers
{
    public class Feature : IFeature
    {
        private readonly Dictionary<string, object> dictionary;

        public Feature()
        {
            dictionary = new Dictionary<string, object>();
            RenderedGeometry = new Dictionary<IStyle, object>();
            Styles = new Collection<IStyle>();
        }

        public IGeometry Geometry { get; set; }

        public IDictionary<IStyle, object> RenderedGeometry { get; private set; }

        public ICollection<IStyle> Styles { get; set; }

        public virtual object this[string key]
        {
            get { return dictionary.ContainsKey(key) ? dictionary[key] : null; }
            set { dictionary[key] = value; }
        }

        public IEnumerable<string> Fields
        {
            get { foreach (var key in dictionary.Keys) yield return key; }
        }
    }

}
