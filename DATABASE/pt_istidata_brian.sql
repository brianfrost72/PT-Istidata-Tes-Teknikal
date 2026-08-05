-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 06, 2026 at 12:55 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pt_istidata_brian`
--

-- --------------------------------------------------------

--
-- Table structure for table `data_karyawan`
--

CREATE TABLE `data_karyawan` (
  `id` int(11) NOT NULL,
  `nik` varchar(20) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `tanggal_lahir` date NOT NULL,
  `jenis_kelamin` enum('Laki-laki','Perempuan') NOT NULL,
  `alamat` text NOT NULL,
  `id_negara` int(11) DEFAULT NULL,
  `dibuat_tgl` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `data_karyawan`
--

INSERT INTO `data_karyawan` (`id`, `nik`, `nama`, `tanggal_lahir`, `jenis_kelamin`, `alamat`, `id_negara`, `dibuat_tgl`) VALUES
(1, '2323213234221123', 'TESA', '2001-03-03', 'Laki-laki', 'awaweaeawe', 1, '2026-08-06 02:28:16'),
(2, '1234567890123123', 'TES', '2001-03-03', 'Laki-laki', 'awaaaw', 2, '2026-08-06 04:04:58'),
(3, '1234567890123123', 'TESI', '1997-01-12', 'Perempuan', 'TES', 3, '2026-08-06 04:06:36'),
(4, '1234567890123123', 'TESIS', '2002-12-12', 'Laki-laki', 'TESIS !23123', 4, '2026-08-06 04:07:06'),
(5, '9876543210987223', 'TESOS', '1980-01-05', 'Perempuan', 'MERIKA', 5, '2026-08-06 04:07:48'),
(6, '2323213234221123', 'TESOSO', '2010-12-12', 'Perempuan', 'awaw', 2, '2026-08-06 04:08:18');

-- --------------------------------------------------------

--
-- Table structure for table `negara`
--

CREATE TABLE `negara` (
  `id` int(11) NOT NULL,
  `negara` varchar(255) NOT NULL,
  `dibuat_tgl` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `negara`
--

INSERT INTO `negara` (`id`, `negara`, `dibuat_tgl`) VALUES
(1, 'Indonesia', '2026-08-05 21:50:59'),
(2, 'Malaysia', '2026-08-05 21:50:59'),
(3, 'Amerika', '2026-08-06 04:05:30'),
(4, 'Konoha', '2026-08-06 04:05:30'),
(5, 'Singapura', '2026-08-06 04:05:58'),
(6, 'Thailand', '2026-08-06 04:05:58');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `data_karyawan`
--
ALTER TABLE `data_karyawan`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_data_karyawan_negara` (`id_negara`);

--
-- Indexes for table `negara`
--
ALTER TABLE `negara`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `data_karyawan`
--
ALTER TABLE `data_karyawan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `negara`
--
ALTER TABLE `negara`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `data_karyawan`
--
ALTER TABLE `data_karyawan`
  ADD CONSTRAINT `fk_data_karyawan_negara` FOREIGN KEY (`id_negara`) REFERENCES `negara` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
