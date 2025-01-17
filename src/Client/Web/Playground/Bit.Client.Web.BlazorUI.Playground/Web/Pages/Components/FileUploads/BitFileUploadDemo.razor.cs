﻿using System;
using System.Collections.Generic;
using Bit.Client.Web.BlazorUI.Playground.Web.Models;
using Bit.Client.Web.BlazorUI.Playground.Web.Pages.Components.ComponentDemoBase;

namespace Bit.Client.Web.BlazorUI.Playground.Web.Pages.Components.FileUploads
{
    public partial class BitFileUploadDemo
    {
        private string UploadUrl = "/FileUpload/UploadStreamedFile";
        private string RemoveUrl = "/FileUpload/RemoveFile";

        private readonly List<ComponentParameter> componentParameters = new()
        {
            new ComponentParameter()
            {
                Name = "AcceptedExtensions",
                Type = "IReadOnlyCollection<string>",
                DefaultValue = "*",
                Description = "Filters files by extension.",
            },
            new ComponentParameter()
            {
                Name = "AutoUploadEnabled",
                Type = "bool",
                DefaultValue = "false",
                Description = "Uploads immediately after selecting the files.",
            },
            new ComponentParameter()
            {
                Name = "ChunkSize",
                Type = "long",
                DefaultValue = "",
                Description = "Upload is done in the form of chunks and this property shows the progress of upload in each chunk.",
            },
            new ComponentParameter()
            {
                Name = "FailedUploadedResultMessage",
                Type = "string",
                DefaultValue = "Uploading failed",
                Description = "Filters files by extension.",
            },
            new ComponentParameter()
            {
                Name = "Files",
                Type = "IReadOnlyList<BitFileInfo>",
                DefaultValue = "",
                Description = "All selected files.",
            },
            new ComponentParameter()
            {
                Name = "FileCount",
                Type = "int",
                DefaultValue = "0",
                Description = "Total count of files uploaded.",
            },
            new ComponentParameter()
            {
                Name = "IsMultiFile",
                Type = "bool",
                DefaultValue = "false",
                Description = "Single is false or multiple is true files upload.",
            },
            new ComponentParameter()
            {
                Name = "Label",
                Type = "string",
                DefaultValue = "Browse",
                Description = "Custom label for browse button.",
            },
            new ComponentParameter()
            {
                Name = "MaxSize",
                Type = "long",
                DefaultValue = "0",
                Description = "Specifies the maximum size of the file.",
            },
            new ComponentParameter()
            {
                Name = "MaxSizeMessage",
                Type = "string",
                DefaultValue = "File size is too large",
                Description = "Specifies the message for the failed uploading progress due to exceeding the maximum size.",
            },
            new ComponentParameter()
            {
                Name = "SuccessfulUploadedResultMessage",
                Type = "string",
                DefaultValue = "File uploaded",
                Description = "Custom label for Failed Status.",
            },
            new ComponentParameter()
            {
                Name = "TotalSize",
                Type = "long",
                DefaultValue = "0",
                Description = "Total size of files.",
            },
            new ComponentParameter()
            {
                Name = "UploadUrl",
                Type = "string",
                DefaultValue = "",
                Description = "URL of the server endpoint receiving the files.",
            },
            new ComponentParameter()
            {
                Name = "UploadedSize",
                Type = "long",
                DefaultValue = "0",
                Description = "Total size of uploaded files.",
            },
            new ComponentParameter()
            {
                Name = "UploadStatus",
                Type = "BitUploadStatus",
                LinkType = LinkType.Link,
                Href = "#uploadstatus-enum",
                DefaultValue = "BitUploadStatus.Pending",
                Description = "General upload status.",
            },
        };

        private readonly List<EnumParameter> enumParameters = new()
        {
            new EnumParameter()
            {
                Id = "uploadstatus-enum",
                Title = "BitUploadStatus Enum",
                Description = "",
                EnumList = new List<EnumItem>()
                {
                    new EnumItem()
                    {
                        Name= "Pending",
                        Description="File uploading progress is pended because the server cannot be contacted.",
                        Value="Pending = 0",
                    },
                    new EnumItem()
                    {
                        Name= "InProgress",
                        Description="File uploading is in progress.",
                        Value="InProgress = 1",
                    },
                    new EnumItem()
                    {
                        Name= "Paused",
                        Description="File uploading progress is paused by the user.",
                        Value="Paused = 2",
                    },
                    new EnumItem()
                    {
                        Name= "Canceled",
                        Description="File uploading progress is canceled by the user.",
                        Value="Canceled = 3",
                    },
                    new EnumItem()
                    {
                        Name= "Completed",
                        Description="The file is successfully uploaded.",
                        Value="Completed = 4",
                    },
                    new EnumItem()
                    {
                        Name= "Failed",
                        Description="The file has a problem and progress is failed.",
                        Value="Failed = 5",
                    },
                    new EnumItem()
                    {
                        Name= "Removed",
                        Description="The uploaded file removed by the user.",
                        Value="Removed = 6",
                    },
                    new EnumItem()
                    {
                        Name= "Unaccepted",
                        Description="The type of uploaded file is not acceptable.",
                        Value="Unaccepted = 7",
                    }
                }
            }
        };

        private readonly string fileUploadSampleCode = $"<BitFileUpload Label='Select or drag and drop files'{Environment.NewLine}" +
             $"UploadUrl='@UploadUrl'{Environment.NewLine}" +
             $"RemoveUrl='@RemoveUrl'>{Environment.NewLine}" +
             "</BitFileUpload>";

        private readonly string autoSampleCode = $"<BitFileUpload IsMultiSelect='true'{Environment.NewLine}" +
           $"Label='Select or drag and drop files'{Environment.NewLine}" +
           $"UploadUrl='@UploadUrl'{Environment.NewLine}" +
           $"RemoveUrl='@RemoveUrl'>{Environment.NewLine}" +
           "</BitFileUpload>";

        private readonly string maxSizeSampleCode = $"<BitFileUpload IsMultiSelect='true'{Environment.NewLine}" +
            $"Label='Select or drag and drop files'{Environment.NewLine}" +
            $"MaxSize='1024 * 1024 * 100'{Environment.NewLine}" +
            $"UploadUrl='@UploadUrl'{Environment.NewLine}" +
            $"RemoveUrl='@RemoveUrl'>{Environment.NewLine}" +
            "</BitFileUpload>";

        private readonly string extensionSampleCode = $"<BitFileUpload IsMultiSelect='true'{Environment.NewLine}" +
            $"Label='Select or drag and drop files'{Environment.NewLine}" +
            $"AllowedExtensions='@(new List<string> {{ '.gif','.jpg','.mp4' }})'{Environment.NewLine}" +
            $"AutoUploadEnabled='false'{Environment.NewLine}" +
            $"UploadUrl='@UploadUrl'{Environment.NewLine}" +
            $"RemoveUrl='@RemoveUrl'>{Environment.NewLine}" +
            "</BitFileUpload>";
    }
}
