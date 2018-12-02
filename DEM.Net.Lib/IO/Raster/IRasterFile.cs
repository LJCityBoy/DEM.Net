﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEM.Net.Lib
{
    public interface IRasterFile : IDisposable
    {
        float GetElevationAtPoint(FileMetadata metadata, int x, int y);
		HeightMap GetHeightMapInBBox(BoundingBox bbox, FileMetadata metadata, float noDataValue = float.MinValue);
        HeightMap GetHeightMap(FileMetadata metadata);

        FileMetadata ParseMetaData();
    }
}
