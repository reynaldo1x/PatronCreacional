﻿using Builder.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Business
{
    public class Car : IBuilder
    {
        private Product _product = new Product();

        // A fresh builder instance should contain a blank product object, which
        // is used in further assembly.
        public Car()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new Product();
        }

        // All production steps work with the same product instance.
        public void ResetCar()
        {
            this._product.Add("ResetCar");
        }

        public void SetSeats()
        {
            this._product.Add("SetSeats");
        }

        public void SetEngine()
        {
            this._product.Add("SetEngine");
        }

        public void SetTripComputer()
        {
            this._product.Add("SetTripComputer");
        }

        public void SetGPS()
        {
            this._product.Add("SetGPS");
        }

        // Concrete Builders are supposed to provide their own methods for
        // retrieving results. That's because various types of builders may
        // create entirely different products that don't follow the same
        // interface. Therefore, such methods cannot be declared in the base
        // Builder interface (at least in a statically typed programming
        // language).
        //
        // Usually, after returning the end result to the client, a builder
        // instance is expected to be ready to start producing another product.
        // That's why it's a usual practice to call the reset method at the end
        // of the `GetProduct` method body. However, this behavior is not
        // mandatory, and you can make your builders wait for an explicit reset
        // call from the client code before disposing of the previous result.
        public Product GetCar()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }
}
