﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Web365Base;
using Web365Domain;

namespace Web365Business.Back_End.IRepository
{
    public interface ILayoutContentRepositoryBE : IBaseRepositoryBE
    {
        List<LayoutContentItem> GetList(out int total, string name, int currentRecord, int numberRecord, string propertyNameSort, bool descending, bool isDelete = false);
        void ResetListPicture(int id, string listPictureId);
    }
}
