using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ImageProcessing
{
    class FilterNode
    {
        private int width;
        private int height;
        private double [,]filter;
        public FilterNode(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public void CreateFilter()
        {
            filter=new double[width,height];
        }
        public void CreateFilter(double value)
        {
            filter = new double[width, height];
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                    filter[i,j] = value;
        }
        public double[,] getFilter()
        {
            return filter;
        }
        public void setFilter(double[,] f)
        {
             filter=f;
        }
    }
}
