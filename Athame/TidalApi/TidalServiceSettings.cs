﻿using Athame.CommonModel;
using OpenTidl.Enums;

namespace Athame.TidalApi
{
    public class TidalServiceSettings : StoredSettings
    {
        public SoundQuality StreamQuality { get; set; }
        public bool AppendVersionToTrackTitle { get; set; }
        public bool DontAppendAlbumVersion { get; set; }

        public TidalServiceSettings()
        {
            StreamQuality = SoundQuality.HIGH;
            AppendVersionToTrackTitle = true;
            DontAppendAlbumVersion = false;
        }
    }
}
