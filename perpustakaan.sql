-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 08, 2022 at 03:50 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `perpustakaan`
--

-- --------------------------------------------------------

--
-- Table structure for table `koleksi`
--

CREATE TABLE `koleksi` (
  `id_koleksi` int(10) UNSIGNED NOT NULL,
  `nama_koleksi` varchar(255) NOT NULL DEFAULT '0',
  `dir_gambar` text NOT NULL,
  `deskripsi` longtext NOT NULL,
  `penerbit` varchar(255) NOT NULL DEFAULT '',
  `jenis_koleksi` varchar(255) NOT NULL DEFAULT '',
  `tahun_terbit` year(4) NOT NULL,
  `lokasi` varchar(255) NOT NULL DEFAULT '',
  `tanggal_masuk_koleksi` date NOT NULL,
  `stock` int(11) NOT NULL DEFAULT 0,
  `bahasa` varchar(50) NOT NULL DEFAULT '0',
  `kategori` varchar(50) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `koleksi`
--

INSERT INTO `koleksi` (`id_koleksi`, `nama_koleksi`, `dir_gambar`, `deskripsi`, `penerbit`, `jenis_koleksi`, `tahun_terbit`, `lokasi`, `tanggal_masuk_koleksi`, `stock`, `bahasa`, `kategori`) VALUES
(3, 'La Tahzan Jangan Bersedih', 'D:/Cover_Book/La_Tahzan.jpeg', 'Dengan Baca Buku Latahzan! Anda akan merasa semangat kembali, atas segala kesedihan yang menimpa anda. Jadi anda tak perlu bersedih, karena Allah selalu bersama kita, karena setelah kesulitan itu pasti ada kemudahan. Berdoa lah agar di jadikan orang yang senantiasa sabar dan selalu bersyukur.', 'Qisthi Press chue', 'Buku', 2001, 'A1', '2022-11-30', 1, 'Bahasa Indonesia', 'Sains|Sosial|'),
(5, 'Quranic Law of Attraction', 'D:/Cover_Book/Quranic_Law_of_Attraction.jpeg', 'Apa yang Anda pikirkan sekarang adalah apa yang akan terjadi pada diri Anda nanti. Masa depan tergantung pada pikiran masa kini. Agar masa depan baik, pikiran berikut keinginan pun harus baik.', 'Rusdin S.', 'Buku', 2022, 'A2', '2022-11-30', 3, 'Bahasa Indonesia', 'Sains|Sosial|Teknologi|'),
(7, 'Otak Tanpa Kotak', 'D:/Cover_Book/Otak_Tanpa_Kotak.jpeg', 'Saat Otak terjebak dalam kotak, membuat akal jadi tumpul dan pemikiran brilian terkungkung. Sayangnya kotak yang menyekat otak itu abstrak, mengurung otak hingga buat ia terjajah. Terjajah tak selamanya terpenjara oleh sekat-sekat penjara , ataukah tertindas oleh moncong-moncong senjata.', 'AL-FATIH PRESS', 'Buku', 2019, 'A3', '2022-11-30', 5, 'Bahasa Indonesia', 'Sains|Sosial|'),
(8, 'Ensiklopedia Geografi', 'D:/Cover_Book/Ensiklopedia_Geografi.jpeg', 'Menyajikan setiap bagian belahan bumi secara terperinci. Selain memperoleh banyak pengetahuan serta membentuk wawasan global, pembaca buku ini akan dapat merasakan sedang mengalami tamasya atau tur keliling dunia yang amat menakjubkan. Dilengkapi ribuan ilustrasi menarik, termasuk foto berwarna serta bendera dan peta setiap negara.', 'Lentera Abadi', 'Ensiklopedia', 2007, 'A4', '2022-12-01', 17, 'Bahasa Indonesia', 'Sains|Sosial|Teknologi|Budaya|'),
(10, 'Kiamat', 'D:/Cover_Book/Ensiklopedia_Kiamat.jpeg', 'Buku Ensiklopedia Kiamat ini hadir dengan format dan isi yang berbeda. Yaitu, format bergambar yang menampilkan gambar-gambar fenomena berbagai peristiwayang telah terjadi yang menunjukkan kebenaran sabda Nabi Muhammad saw. dan bukti telah adanya tanda-tanda Kiamat. Dari segi isi, buku ini berusaha merangkum berbagai informasi mengenai pengetahuan seputar Kiamat dari beberapa buku yang telah ada menjadi satu kesatuan yang utuh dengan tetap memegang pedoman sumber yang pasti, yaitu Al-Qur’an dan Al-Hadits dengan sanad-sanad yang shahih. Buku ini menjelaskan secara ringkas dan padat mengenai nama-nama hari Kiamat yang tercantum dalam Al-Qur’an, tanda-tanda sebelum datangnya hari Kiamat, munculnya Dajjal, turunnya Al-Mahdi, peristiwa terjadinya hari Kiamat, pengumpulan manusia di Padang Mahsyar, Mizan, para penghuni al-A‘raf, ash-Shirath hingga kedatangan manusia ke surga dan neraka beserta sifatnya. Dalam penyajiannya, buku ini juga dilengkapi dengan catatan samping di setiap halaman yang berisi poin-poin penting dari setiap pembahasan sehingga memudahkan pembaca dalam memahami inti pembahasan.', 'Gema Insani', 'Ensiklopedia', 2014, 'A5', '2022-12-01', 3, 'Bahasa Indonesia', 'Sains|Sosial|'),
(12, 'Salah Urus Minyak Goreng', 'D:/Cover_Book/Majalah_Salah_Urus_Minyak_Goreng.jpeg', 'Pemerintah kelimpungan meredam harga minyak goreng akibat gejolak harga sawit dunia yang tak terkendali. Strategi kebijakan satu harga, subsidi dana sawit, juga minyak murah tak kunjung bisa membuat harga minyak goreng turun dan pasokan lancar. Disemprit urusan subsidi, Kementerian Perdagangan mengeluarkan jurus ketiga: membatasi harga bahan baku dan izin ekspor. Akibat murah hati kepada baron sawit.', 'Tempo', 'Majalah', 2022, 'A7', '2022-12-02', 15, 'Bahasa Inggris', 'Sosial|'),
(13, 'Machine Learning Science and Technology', 'D:/Cover_Book/Machine Learning Science And Technology.jpeg', 'This should be concise and describe the nature of the problem under investigation and its background. It should also set your work in the context of previous research, citing relevant references. Introductions should expand on highly specialised terms and abbreviations used in the article to make it accessible for readers.', 'IOP Publishing', 'Publikasi', 2022, 'A8', '2022-12-03', 5, 'Bahasa Inggris', 'Sains|Teknologi|'),
(14, 'Molecular Systems Biology', 'D:/Cover_Book/Molecular System Biology.jpeg', 'Donnelly Centre researchers have developed a deep learning algorithm that can track proteins, to help reveal what makes cells healthy and what goes wrong in disease', 'University of Toronto', 'Publikasi', 2017, 'A9', '2022-12-03', 3, 'Bahasa Inggris', 'Sains|Teknologi|'),
(26, 'Marketing Sisi Gelap Media Sosial', 'D:/Cover_Book/Marketing_Sisi_Gelap_Media_Sosial.jpeg', 'Setiap kali ada perselisihan seperti itu, pada kenyataannya, bukan perselisihan itu sendiri yang menarik perhatian Ricky. Melainkan, ekspresi emosional netizen selama perselisihan. Itulah, sisi terang dan sisi gelap media sosial.', 'PT Info Cahaya Hero', 'Majalah', 2017, 'A6', '2022-12-08', 10, 'Bahasa Indonesia', 'Sains|Sosial|Teknologi|Budaya|');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id_user` int(11) UNSIGNED ZEROFILL NOT NULL,
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `registered_at` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id_user`, `username`, `password`, `registered_at`) VALUES
(00000000001, 'marwah', 'd79c8788088c2193f0244d8f1f36d2db', '2022-12-07'),
(00000000002, 'shafira', '2be9bd7a3434f7038ca27d1918de58bd', '2022-12-07'),
(00000000003, 'nur', '934b535800b1cba8f96a5d72f72f1611', '2022-12-07'),
(00000000004, 'marns17', 'b5cdec69f15d32da9cbcf45b9137d1ca', '2022-12-08');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `koleksi`
--
ALTER TABLE `koleksi`
  ADD PRIMARY KEY (`id_koleksi`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `koleksi`
--
ALTER TABLE `koleksi`
  MODIFY `id_koleksi` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id_user` int(11) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
