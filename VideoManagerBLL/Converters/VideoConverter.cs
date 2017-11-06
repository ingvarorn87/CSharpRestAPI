using System;
using System.Collections.Generic;
using System.Text;
using VideoManagerBLL.BusinessObjects;
using VideoManagerDAL.Entities;

namespace VideoManagerBLL.Converters
{
    class VideoConverter
    {
        internal Video Convert(VideoBO vid)
        {
            if (vid == null)
            {
                return null;
            }
            return new Video()
            {
                Id = vid.Id,
                VideoName = vid.VideoName,
                Year = vid.Year,
                Genre = vid.Genre

            };
        }
        internal VideoBO Convert(Video vid)
        {
            if (vid == null)
            {
                return null;
            }
            return new VideoBO()
            {
                Id = vid.Id,
                VideoName = vid.VideoName,
                Year = vid.Year,
                Genre = vid.Genre

            };
        }
    }
}
