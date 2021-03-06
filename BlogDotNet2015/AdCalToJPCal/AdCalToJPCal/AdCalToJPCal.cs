﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Globalization;

/// <summary>
/// Copyright (C) 2016- @rey1229/@rey_DVL All Rights Reserved.
/// 
/// rey’s developer blog
/// http://rey1229.hatenablog.com/
/// </summary>
namespace AdCalToJPCal
{
    /// <summary>
    /// 西暦から和暦変換テスト
    /// </summary>
    class AdCalToJPCal
    {
        /// <summary>
        /// 西暦から和暦変換テスト
        /// </summary>
        /// <param name="args">コマンドライン引数</param>
        static void Main(string[] args)
        {
            ArrayList adList = new ArrayList();
            //グレゴリウス暦導入前
            adList.Add(new int[] { 1868, 1, 1 });
            adList.Add(new int[] { 1868, 1, 1 });
            adList.Add(new int[] { 1868, 1, 25 });
            adList.Add(new int[] { 1868, 9, 7 });
            adList.Add(new int[] { 1868, 9, 8 });
            adList.Add(new int[] { 1868, 9, 9 });
            adList.Add(new int[] { 1868, 10, 22 });
            adList.Add(new int[] { 1868, 10, 23 });
            adList.Add(new int[] { 1872, 12, 31 });
            //グレゴリウス暦導入
            adList.Add(new int[] { 1873, 1, 1 });
            //明治→大正
            adList.Add(new int[] { 1912, 1, 1 });
            adList.Add(new int[] { 1912, 7, 29 });
            adList.Add(new int[] { 1912, 7, 30 });
            //大正→昭和
            adList.Add(new int[] { 1926, 1, 1 });
            adList.Add(new int[] { 1926, 12, 24 });
            adList.Add(new int[] { 1926, 12, 25 });
            //昭和→平成
            adList.Add(new int[] { 1989, 1, 1 });
            adList.Add(new int[] { 1989, 1, 7 });
            adList.Add(new int[] { 1989, 1, 8 });

            CultureInfo culture = new CultureInfo("ja-JP", true);
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();

            foreach (int[] iArr in adList)
            {
                try
                {
                    DateTime target = new DateTime(iArr[0], iArr[1], iArr[2]);
                    Console.WriteLine("西暦" + iArr[0] + "年" + iArr[1] + "月" + iArr[2] + "日 → " + target.ToString("gyy年M月d日", culture));
                }
                catch(Exception e)
                {
                    Console.WriteLine("Exception：西暦" + iArr[0] + "年" + iArr[1] + "月" + iArr[2] + "日");
                }
            }

            Console.WriteLine("何かキーを押してください。");
            Console.ReadKey();
        }
    }
}
