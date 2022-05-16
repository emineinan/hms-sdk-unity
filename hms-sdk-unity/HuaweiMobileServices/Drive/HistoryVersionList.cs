﻿using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class HistoryVersionList : JavaObjectWrapper
    {
        public HistoryVersionList(AndroidJavaObject javaObject) : base(javaObject) { }
        public HistoryVersionList() : base("com.huawei.cloud.services.drive.model.HistoryVersionList") { }

        public string GetId() => Call<string>("getId");
        public HistoryVersion SetId(string var1) => CallAsWrapper<HistoryVersion>("setId", var1);

        public bool GetKeepPermanent() => Call<bool>("getKeepPermanent");
        public HistoryVersion SetKeepPermanent(bool var1) => CallAsWrapper<HistoryVersion>("setKeepPermanent", var1);

        public string GetCategory() => Call<string>("getCategory");
        public HistoryVersion SetCategory(string var1) => CallAsWrapper<HistoryVersion>("setCategory", var1);

        public User GetLastEditor() => CallAsWrapper<User>("getLastEditor");
        public HistoryVersion SetLastEditor(User var1) => CallAsWrapper<HistoryVersion>("setLastEditor", var1);

        public string GetSha256() => Call<string>("getSha256");
        public HistoryVersion SetSha256(string var1) => CallAsWrapper<HistoryVersion>("setSha256", var1);

        public string GetMimeType() => Call<string>("getMimeType");
        public HistoryVersion SetMimeType(string var1) => CallAsWrapper<HistoryVersion>("setMimeType", var1);

        public string GetOriginalFilename() => Call<string>("getOriginalFilename");
        public HistoryVersion SetOriginalFilename(string var1) => CallAsWrapper<HistoryVersion>("setOriginalFilename", var1);

        public long GetSize() => Call<long>("getSize");
        public HistoryVersion SetSize(long var1) => CallAsWrapper<HistoryVersion>("setSize", var1);

        public HistoryVersion Set(string var1, AndroidJavaObject var2) => CallAsWrapper<HistoryVersion>("set", var1, var2);
        public HistoryVersion Clone() => CallAsWrapper<HistoryVersion>("clone");
    }
}
