using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace CalculadoraTeste
{
    public class CalculadoraServiceTest
    {
        
        private CalculadoraService _calculadora = new();
        public CalculadoraServiceTest()
        {
            _calculadora = new();
        }
            

        [Fact]
        public void DeveSomar10com5ERetornar15()
        {
            // Arrange
            int a = 10;
            int b = 5;

            // Act
            int resutado = _calculadora.Somar(a, b);

            // Assert

            Assert.Equal(15, resutado);
        }

        [Fact]
        public void DeveVerificarSe4EhParERetornarVerdadeiro()
        {
            // Arrange
            int num = 4;

            // Act
            bool result = _calculadora.EhPar(num);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(new int[] { 2, 4})]
        [InlineData(new int[] { 6, 8, 104})]

        public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] nums)
        {

            //Act / Assert
            Assert.All(nums, num => Assert.True(_calculadora.EhPar(num)));
        }


    }
}