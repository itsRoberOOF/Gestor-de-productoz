-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 21-07-2021 a las 05:56:54
-- Versión del servidor: 10.4.18-MariaDB
-- Versión de PHP: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `dbexpo`
--
CREATE DATABASE IF NOT EXISTS `dbexpo` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `dbexpo`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bodega`
--

CREATE TABLE `bodega` (
  `idbodega` int(11) NOT NULL,
  `espacio` int(5) NOT NULL,
  `idestadobod` int(2) NOT NULL,
  `idmunicipio` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `departamento`
--

CREATE TABLE `departamento` (
  `iddepartamento` int(11) NOT NULL,
  `nombre_de` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detallemarcaproducto`
--

CREATE TABLE `detallemarcaproducto` (
  `iddetallemarcaprodu` int(11) NOT NULL,
  `idmarca` int(11) NOT NULL,
  `idproducto` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleado`
--

CREATE TABLE `empleado` (
  `idempleado` int(11) NOT NULL,
  `nombres_emp` varchar(30) NOT NULL,
  `apellidos_emp` varchar(30) NOT NULL,
  `direccion_emp` varchar(250) NOT NULL,
  `telefono_emp` varchar(9) NOT NULL,
  `dui_emp` varchar(10) NOT NULL,
  `idestadoemp` int(2) NOT NULL,
  `idtipoemp` int(3) NOT NULL,
  `idestadocivilemp` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estadobodega`
--

CREATE TABLE `estadobodega` (
  `idestadobod` int(2) NOT NULL,
  `nombre_estadobod` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estadocivilempleado`
--

CREATE TABLE `estadocivilempleado` (
  `idestadocivilemp` int(2) NOT NULL,
  `nombre_estdcivil` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estadoempleado`
--

CREATE TABLE `estadoempleado` (
  `idestadoemp` int(2) NOT NULL,
  `nombre_estadoemp` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estadolote`
--

CREATE TABLE `estadolote` (
  `idestadolote` int(2) NOT NULL,
  `nombre_estadolote` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `estadolote`
--

INSERT INTO `estadolote` (`idestadolote`, `nombre_estadolote`) VALUES
(1, 'Disponible'),
(2, 'Agotado');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estadomarca`
--

CREATE TABLE `estadomarca` (
  `idestadomarca` int(2) NOT NULL,
  `nombre_estadomarca` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `estadomarca`
--

INSERT INTO `estadomarca` (`idestadomarca`, `nombre_estadomarca`) VALUES
(1, 'Activo'),
(2, 'No disponible');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estadoproducto`
--

CREATE TABLE `estadoproducto` (
  `idestadoprodu` int(2) NOT NULL,
  `nombre_estadoprodu` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `estadoproducto`
--

INSERT INTO `estadoproducto` (`idestadoprodu`, `nombre_estadoprodu`) VALUES
(1, 'Disponible'),
(2, 'Sin stock'),
(3, 'Vencido');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estadoproveedor`
--

CREATE TABLE `estadoproveedor` (
  `idestadoprov` int(2) NOT NULL,
  `nombre_estadoprv` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `estadoproveedor`
--

INSERT INTO `estadoproveedor` (`idestadoprov`, `nombre_estadoprv`) VALUES
(1, 'Activo'),
(2, 'No disponible');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estadousuario`
--

CREATE TABLE `estadousuario` (
  `idestadousu` int(2) NOT NULL,
  `nombre_estadousu` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `kardex`
--

CREATE TABLE `kardex` (
  `idkardex` int(11) NOT NULL,
  `fecha` date NOT NULL,
  `cantidad` int(11) NOT NULL,
  `preciototal` decimal(11,2) NOT NULL,
  `idproducto` int(11) NOT NULL,
  `idbodega` int(11) NOT NULL,
  `idusuario` int(11) NOT NULL,
  `idtipooperacion` int(1) NOT NULL,
  `idtipokardex` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `lote`
--

CREATE TABLE `lote` (
  `idlote` int(11) NOT NULL,
  `numlote` varchar(12) NOT NULL,
  `cantildadlote` int(11) NOT NULL,
  `idestadolote` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `lote`
--

INSERT INTO `lote` (`idlote`, `numlote`, `cantildadlote`, `idestadolote`) VALUES
(1, 'CMW4787000Z1', 1000, 1),
(2, 'OOF280506ZZZ', 5000, 2),
(3, 'RCMG908760ZO', 20, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `marca`
--

CREATE TABLE `marca` (
  `idmarca` int(11) NOT NULL,
  `nombre_marca` varchar(60) NOT NULL,
  `idestadomarca` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `marca`
--

INSERT INTO `marca` (`idmarca`, `nombre_marca`, `idestadomarca`) VALUES
(1, 'Dell', 1),
(2, 'Mabe', 2),
(3, 'Samsung', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `municipio`
--

CREATE TABLE `municipio` (
  `idmunicipio` int(3) NOT NULL,
  `nombre_mu` varchar(60) NOT NULL,
  `iddepartamento` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE `producto` (
  `idproducto` int(11) NOT NULL,
  `nombre_pr` varchar(60) NOT NULL,
  `descripcion_pr` varchar(300) NOT NULL,
  `fecha_de_elb_pr` date NOT NULL,
  `fecha_de_exp_pr` date DEFAULT NULL,
  `precio_pr` decimal(11,2) NOT NULL,
  `peso_pr` decimal(11,2) DEFAULT 0.00,
  `codigo_de_barra_pr` varchar(13) DEFAULT '0',
  `idlote` int(11) NOT NULL,
  `idproveedor` int(11) NOT NULL,
  `idestadoprodu` int(2) NOT NULL,
  `idtipoproducto` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`idproducto`, `nombre_pr`, `descripcion_pr`, `fecha_de_elb_pr`, `fecha_de_exp_pr`, `precio_pr`, `peso_pr`, `codigo_de_barra_pr`, `idlote`, `idproveedor`, `idestadoprodu`, `idtipoproducto`) VALUES
(1, 'Laptop 2tb', 'Laptop piola con 2tb de memoria', '2017-07-20', NULL, '2500.00', '0.00', NULL, 1, 1, 1, 3),
(2, 'Refri mabe v5', 'Refri para la prueba intento 5', '2018-06-25', '2021-07-07', '0.00', '5000.00', '0', 3, 3, 2, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

CREATE TABLE `proveedor` (
  `idproveedor` int(11) NOT NULL,
  `nombres_prv` varchar(30) NOT NULL,
  `apellidos_prv` varchar(30) NOT NULL,
  `direccion_prv` varchar(250) NOT NULL,
  `telefono_prv` varchar(9) NOT NULL,
  `correo_prv` varchar(60) NOT NULL,
  `idestadoprov` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `proveedor`
--

INSERT INTO `proveedor` (`idproveedor`, `nombres_prv`, `apellidos_prv`, `direccion_prv`, `telefono_prv`, `correo_prv`, `idestadoprov`) VALUES
(1, 'Pepito Juan', 'Gonzales Cordova', 'San Salvador', '0000-0000', 'pepitojuan@gmail.com', 1),
(2, 'Kevin Sebastian', 'Rojas Mallma', 'Ahuachapán', '1111-1111', 'mallma123@gmail.com', 2),
(3, 'Daniel Marino', 'Fuentes Lopez', 'Mejicanos', '2222-2222', 'marino478@gmail.com', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipoempleado`
--

CREATE TABLE `tipoempleado` (
  `idtipoemp` int(3) NOT NULL,
  `nombre_tipoemp` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipokardex`
--

CREATE TABLE `tipokardex` (
  `idtipokardex` int(1) NOT NULL,
  `nombre_tipokardex` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipooperacion`
--

CREATE TABLE `tipooperacion` (
  `idtipooperacion` int(1) NOT NULL,
  `nombre_tipoope` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipoproducto`
--

CREATE TABLE `tipoproducto` (
  `idtipoproducto` int(11) NOT NULL,
  `nombre_tipoproducto` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tipoproducto`
--

INSERT INTO `tipoproducto` (`idtipoproducto`, `nombre_tipoproducto`) VALUES
(1, 'Telefóno'),
(2, 'Refrigerador'),
(3, 'Computadora'),
(4, 'Televisión'),
(5, 'Verdura');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipousuario`
--

CREATE TABLE `tipousuario` (
  `idtipousu` int(3) NOT NULL,
  `nombre_tipousu` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `idusuario` int(11) NOT NULL,
  `nombre_usuario` varchar(30) NOT NULL,
  `contra_usuario` varchar(20) NOT NULL,
  `idestadousu` int(2) NOT NULL,
  `idempleado` int(11) NOT NULL,
  `idtipousu` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `bodega`
--
ALTER TABLE `bodega`
  ADD PRIMARY KEY (`idbodega`),
  ADD KEY `idmunicipio` (`idmunicipio`),
  ADD KEY `idestadobod` (`idestadobod`);

--
-- Indices de la tabla `departamento`
--
ALTER TABLE `departamento`
  ADD PRIMARY KEY (`iddepartamento`);

--
-- Indices de la tabla `detallemarcaproducto`
--
ALTER TABLE `detallemarcaproducto`
  ADD PRIMARY KEY (`iddetallemarcaprodu`),
  ADD KEY `idmarca` (`idmarca`),
  ADD KEY `idproducto` (`idproducto`);

--
-- Indices de la tabla `empleado`
--
ALTER TABLE `empleado`
  ADD PRIMARY KEY (`idempleado`),
  ADD KEY `idestadoemp` (`idestadoemp`),
  ADD KEY `idtipoemp` (`idtipoemp`),
  ADD KEY `idestadocivilemp` (`idestadocivilemp`);

--
-- Indices de la tabla `estadobodega`
--
ALTER TABLE `estadobodega`
  ADD PRIMARY KEY (`idestadobod`);

--
-- Indices de la tabla `estadocivilempleado`
--
ALTER TABLE `estadocivilempleado`
  ADD PRIMARY KEY (`idestadocivilemp`);

--
-- Indices de la tabla `estadoempleado`
--
ALTER TABLE `estadoempleado`
  ADD PRIMARY KEY (`idestadoemp`);

--
-- Indices de la tabla `estadolote`
--
ALTER TABLE `estadolote`
  ADD PRIMARY KEY (`idestadolote`);

--
-- Indices de la tabla `estadomarca`
--
ALTER TABLE `estadomarca`
  ADD PRIMARY KEY (`idestadomarca`);

--
-- Indices de la tabla `estadoproducto`
--
ALTER TABLE `estadoproducto`
  ADD PRIMARY KEY (`idestadoprodu`);

--
-- Indices de la tabla `estadoproveedor`
--
ALTER TABLE `estadoproveedor`
  ADD PRIMARY KEY (`idestadoprov`);

--
-- Indices de la tabla `estadousuario`
--
ALTER TABLE `estadousuario`
  ADD PRIMARY KEY (`idestadousu`);

--
-- Indices de la tabla `kardex`
--
ALTER TABLE `kardex`
  ADD PRIMARY KEY (`idkardex`),
  ADD KEY `idproducto` (`idproducto`),
  ADD KEY `idtipokardex` (`idtipokardex`),
  ADD KEY `idusuario` (`idusuario`),
  ADD KEY `idtipooperacion` (`idtipooperacion`),
  ADD KEY `idbodega` (`idbodega`);

--
-- Indices de la tabla `lote`
--
ALTER TABLE `lote`
  ADD PRIMARY KEY (`idlote`),
  ADD KEY `idestadolote` (`idestadolote`);

--
-- Indices de la tabla `marca`
--
ALTER TABLE `marca`
  ADD PRIMARY KEY (`idmarca`),
  ADD KEY `idestadomarca` (`idestadomarca`);

--
-- Indices de la tabla `municipio`
--
ALTER TABLE `municipio`
  ADD PRIMARY KEY (`idmunicipio`),
  ADD KEY `iddepartamento` (`iddepartamento`);

--
-- Indices de la tabla `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`idproducto`),
  ADD KEY `idlote` (`idlote`),
  ADD KEY `idproveedor` (`idproveedor`),
  ADD KEY `idestadoprodu` (`idestadoprodu`),
  ADD KEY `idtipoproducto` (`idtipoproducto`);

--
-- Indices de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD PRIMARY KEY (`idproveedor`),
  ADD KEY `idestadoprov` (`idestadoprov`);

--
-- Indices de la tabla `tipoempleado`
--
ALTER TABLE `tipoempleado`
  ADD PRIMARY KEY (`idtipoemp`);

--
-- Indices de la tabla `tipokardex`
--
ALTER TABLE `tipokardex`
  ADD PRIMARY KEY (`idtipokardex`);

--
-- Indices de la tabla `tipooperacion`
--
ALTER TABLE `tipooperacion`
  ADD PRIMARY KEY (`idtipooperacion`);

--
-- Indices de la tabla `tipoproducto`
--
ALTER TABLE `tipoproducto`
  ADD PRIMARY KEY (`idtipoproducto`);

--
-- Indices de la tabla `tipousuario`
--
ALTER TABLE `tipousuario`
  ADD PRIMARY KEY (`idtipousu`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`idusuario`),
  ADD UNIQUE KEY `idempleado` (`idempleado`),
  ADD KEY `idestadousu` (`idestadousu`),
  ADD KEY `idtipousu` (`idtipousu`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `bodega`
--
ALTER TABLE `bodega`
  MODIFY `idbodega` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `departamento`
--
ALTER TABLE `departamento`
  MODIFY `iddepartamento` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `detallemarcaproducto`
--
ALTER TABLE `detallemarcaproducto`
  MODIFY `iddetallemarcaprodu` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `empleado`
--
ALTER TABLE `empleado`
  MODIFY `idempleado` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `estadobodega`
--
ALTER TABLE `estadobodega`
  MODIFY `idestadobod` int(2) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `estadocivilempleado`
--
ALTER TABLE `estadocivilempleado`
  MODIFY `idestadocivilemp` int(2) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `estadoempleado`
--
ALTER TABLE `estadoempleado`
  MODIFY `idestadoemp` int(2) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `estadolote`
--
ALTER TABLE `estadolote`
  MODIFY `idestadolote` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `estadomarca`
--
ALTER TABLE `estadomarca`
  MODIFY `idestadomarca` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `estadoproducto`
--
ALTER TABLE `estadoproducto`
  MODIFY `idestadoprodu` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `estadoproveedor`
--
ALTER TABLE `estadoproveedor`
  MODIFY `idestadoprov` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `estadousuario`
--
ALTER TABLE `estadousuario`
  MODIFY `idestadousu` int(2) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `kardex`
--
ALTER TABLE `kardex`
  MODIFY `idkardex` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `lote`
--
ALTER TABLE `lote`
  MODIFY `idlote` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `marca`
--
ALTER TABLE `marca`
  MODIFY `idmarca` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `municipio`
--
ALTER TABLE `municipio`
  MODIFY `idmunicipio` int(3) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `producto`
--
ALTER TABLE `producto`
  MODIFY `idproducto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  MODIFY `idproveedor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `tipoempleado`
--
ALTER TABLE `tipoempleado`
  MODIFY `idtipoemp` int(3) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tipokardex`
--
ALTER TABLE `tipokardex`
  MODIFY `idtipokardex` int(1) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tipooperacion`
--
ALTER TABLE `tipooperacion`
  MODIFY `idtipooperacion` int(1) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tipoproducto`
--
ALTER TABLE `tipoproducto`
  MODIFY `idtipoproducto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `tipousuario`
--
ALTER TABLE `tipousuario`
  MODIFY `idtipousu` int(3) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `usuario`
--
ALTER TABLE `usuario`
  MODIFY `idusuario` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `bodega`
--
ALTER TABLE `bodega`
  ADD CONSTRAINT `bodega_ibfk_1` FOREIGN KEY (`idmunicipio`) REFERENCES `municipio` (`idmunicipio`),
  ADD CONSTRAINT `bodega_ibfk_2` FOREIGN KEY (`idestadobod`) REFERENCES `estadobodega` (`idestadobod`);

--
-- Filtros para la tabla `detallemarcaproducto`
--
ALTER TABLE `detallemarcaproducto`
  ADD CONSTRAINT `detallemarcaproducto_ibfk_1` FOREIGN KEY (`idmarca`) REFERENCES `marca` (`idmarca`),
  ADD CONSTRAINT `detallemarcaproducto_ibfk_2` FOREIGN KEY (`idproducto`) REFERENCES `producto` (`idproducto`);

--
-- Filtros para la tabla `empleado`
--
ALTER TABLE `empleado`
  ADD CONSTRAINT `empleado_ibfk_1` FOREIGN KEY (`idestadoemp`) REFERENCES `estadoempleado` (`idestadoemp`),
  ADD CONSTRAINT `empleado_ibfk_2` FOREIGN KEY (`idtipoemp`) REFERENCES `tipoempleado` (`idtipoemp`),
  ADD CONSTRAINT `empleado_ibfk_3` FOREIGN KEY (`idestadocivilemp`) REFERENCES `estadocivilempleado` (`idestadocivilemp`);

--
-- Filtros para la tabla `kardex`
--
ALTER TABLE `kardex`
  ADD CONSTRAINT `kardex_ibfk_1` FOREIGN KEY (`idproducto`) REFERENCES `producto` (`idproducto`),
  ADD CONSTRAINT `kardex_ibfk_2` FOREIGN KEY (`idtipokardex`) REFERENCES `tipokardex` (`idtipokardex`),
  ADD CONSTRAINT `kardex_ibfk_3` FOREIGN KEY (`idusuario`) REFERENCES `usuario` (`idusuario`),
  ADD CONSTRAINT `kardex_ibfk_4` FOREIGN KEY (`idtipooperacion`) REFERENCES `tipooperacion` (`idtipooperacion`),
  ADD CONSTRAINT `kardex_ibfk_5` FOREIGN KEY (`idbodega`) REFERENCES `bodega` (`idbodega`);

--
-- Filtros para la tabla `lote`
--
ALTER TABLE `lote`
  ADD CONSTRAINT `lote_ibfk_1` FOREIGN KEY (`idestadolote`) REFERENCES `estadolote` (`idestadolote`);

--
-- Filtros para la tabla `marca`
--
ALTER TABLE `marca`
  ADD CONSTRAINT `marca_ibfk_1` FOREIGN KEY (`idestadomarca`) REFERENCES `estadomarca` (`idestadomarca`);

--
-- Filtros para la tabla `municipio`
--
ALTER TABLE `municipio`
  ADD CONSTRAINT `municipio_ibfk_1` FOREIGN KEY (`iddepartamento`) REFERENCES `departamento` (`iddepartamento`);

--
-- Filtros para la tabla `producto`
--
ALTER TABLE `producto`
  ADD CONSTRAINT `producto_ibfk_1` FOREIGN KEY (`idlote`) REFERENCES `lote` (`idlote`),
  ADD CONSTRAINT `producto_ibfk_2` FOREIGN KEY (`idproveedor`) REFERENCES `proveedor` (`idproveedor`),
  ADD CONSTRAINT `producto_ibfk_3` FOREIGN KEY (`idestadoprodu`) REFERENCES `estadoproducto` (`idestadoprodu`),
  ADD CONSTRAINT `producto_ibfk_4` FOREIGN KEY (`idtipoproducto`) REFERENCES `tipoproducto` (`idtipoproducto`);

--
-- Filtros para la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD CONSTRAINT `proveedor_ibfk_1` FOREIGN KEY (`idestadoprov`) REFERENCES `estadoproveedor` (`idestadoprov`);

--
-- Filtros para la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD CONSTRAINT `usuario_ibfk_1` FOREIGN KEY (`idempleado`) REFERENCES `empleado` (`idempleado`),
  ADD CONSTRAINT `usuario_ibfk_2` FOREIGN KEY (`idestadousu`) REFERENCES `estadousuario` (`idestadousu`),
  ADD CONSTRAINT `usuario_ibfk_3` FOREIGN KEY (`idtipousu`) REFERENCES `tipousuario` (`idtipousu`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
