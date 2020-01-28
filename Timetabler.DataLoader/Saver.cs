﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Timetabler.Data;
using Timetabler.DataLoader.Save.Yaml;
using Timetabler.SerialData.Yaml;
using YamlDotNet.Serialization;

namespace Timetabler.DataLoader
{
    /// <summary>
    /// The main data saving API
    /// </summary>
    public static class Saver
    {
        /// <summary>
        /// Save a timetable document to a stream.
        /// </summary>
        /// <param name="document">The document to be saved.</param>
        /// <param name="destination">The stream to save the document to.</param>
        public static void Save(TimetableDocument document, Stream destination)
        {
            //XmlSerializer serializer = new XmlSerializer(typeof(TimetableFileModel));
            //serializer.Serialize(destination, document.ToTimetableFileModel());
            ISerializer serializer = GetSerializer();
            using (StreamWriter writer = new StreamWriter(destination))
            {
                writer.WriteLine("%WTT");
                serializer.Serialize(writer, document.ToYamlTimetableFileModel());
            } 
        }

        /// <summary>
        /// Save a location template to a stream.
        /// </summary>
        /// <param name="locations">The list of locations to include in the template.</param>
        /// <param name="destination">The stream to save the location template to.</param>
        public static void Save(IEnumerable<Location> locations, Stream destination)
        {
            //XmlSerializer serializer = new XmlSerializer(typeof(LocationTemplateModel));
            //NetworkMapModel networkMapModel = new NetworkMapModel();
            //networkMapModel.LocationList.AddRange(locations.Select(c => c.ToLocationModel()));
            //LocationTemplateModel locationTemplateModel = new LocationTemplateModel();
            //locationTemplateModel.Maps.Add(networkMapModel);
            //serializer.Serialize(destination, locationTemplateModel);
            LocationTemplateModel locationTemplateModel = new LocationTemplateModel();
            locationTemplateModel.Maps = new List<NetworkMapModel> { new NetworkMapModel { LocationList = locations.Select(c => c.ToYamlLocationModel()).ToList() } };
            ISerializer serialiser = GetSerializer();
            using (StreamWriter writer = new StreamWriter(destination))
            {
                writer.WriteLine("%WTL");
                serialiser.Serialize(writer, locationTemplateModel);
            }
        }

        /// <summary>
        /// Save a document template to a stream.
        /// </summary>
        /// <param name="template">The <see cref="DocumentTemplate"/> to be saved.</param>
        /// <param name="destination">The stream to save the location template to.</param>
        public static void Save(DocumentTemplate template, Stream destination)
        {
            // XmlSerializer serializer = new XmlSerializer(typeof(TimetableDocumentTemplateModel));
            // serializer.Serialize(destination, template.ToTimetableDocumentTemplateModel());
            ISerializer serializer = GetSerializer();
            using (StreamWriter writer = new StreamWriter(destination))
            {
                writer.WriteLine("%WTM");
                serializer.Serialize(writer, template.ToYamlTimetableDocumentTemplateModel());
            }
        }

        private static ISerializer GetSerializer()
        {
            return new SerializerBuilder().ConfigureDefaultValuesHandling(DefaultValuesHandling.OmitNull).Build();
        }
    }
}
