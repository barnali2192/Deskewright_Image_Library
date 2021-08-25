using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AForge.Imaging.Filters;
using System.Drawing;
//using System.Drawing.Imaging;


namespace Deskew_Image_Library
{
    public class Image_deskew
    {
        //class property
        public string image{ get; set;}
        public int Width { get; set; }
        public int Height { get; set; }

        public double skewangle(double angle)
        {
            double ang = angle*Math.PI/180; //skew angle calculation
            return ang;
        }
        //check after rotation length and width 
         public void imageSize( float sourceData,float  destinationdata){
             Width = sourceData.width;
             Height = sourceData.height;
             double oldXradius = (double)(Width - 1) / 2;
             double oldYradius = (double)(Height - 1) / 2;

             int newWidth = destinationdata.width;
             int newHeight = destinationdata.Height;
             double newXradius = (double)(newWidth - 1) / 2;
             double newYradius = (double)(newHeight - 1) / 2;
            
         }
        //image deskew method
        public string DeskewRight()
        {           
              string imagefile="C:\\Users\\Tanumoy Biswas\\Desktop";
              Image img;//instance of image
              img = image.Contains(imagefile);//contain image from image file
              RotateBilinear rotate = new RotateBilinear(15,true);//rotate image by 15 degree angle
              string imageNew = rotate.Apply(img);//store rotated image
              return imageNew ;
                              
         }              
       }
     }

        

    

